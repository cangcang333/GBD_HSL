using BWM01;
using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.Siemens;
using MySql.Data.MySqlClient;
using S7.Net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GBD.GlobalData;

namespace GBD
{
   

    public partial class MainForm : Form
    {

        SiemensS7Net sieMeasure = null;
        SiemensS7Net sieShrinkage = null;
        SiemensS7Net sieRecheck = null;

        PrintDocument pdDocument = new PrintDocument();
        private string stringToPrint;

        public static int XOFFSET = 250;
        public static int YOFFSET = 210;

        static string csvFileName1 = "";
        static string csvFileName2 = "";
        static string csvFileName3 = "";
        static bool fileFlag1 = false;
        static bool fileFlag2 = false;
        static bool fileFlag3 = false;

        static string csvRecheckFileName1 = "";
        static string csvRecheckFileName2 = "";
        static string csvRecheckFileName3 = "";
        static bool fileRecheckFlag1 = false;
        static bool fileRecheckFlag2 = false;
        static bool fileRecheckFlag3 = false;


        public MainForm()
        {
            Log.Init();

            InitializeComponent();

            this.Load += MainForm_Load;

            /*
            this.Load += OpenPlc;
            this.Load += HandlingPLCData;
            */

            InitializeMainForm();

            Control.CheckForIllegalCrossThreadCalls = false;

            if (false == MysqlOperation.ConnectDb())
            {
                Log.Error("错误，连接数据库失败");
            }
        }

        private void InitializeMainForm()
        {

            // 进行 Common.Init， 检查 sys.config 配置文件是否存在
            if (Constants.FAILURE == Common.ConfigFileCheck())
            {
                MessageBox.Show("重要配置文件 sys.config 不存在，无法进行登录操作，请确保运行文件夹中存在 sys.config 配置文件");
                Log.Error("重要配置文件 sys.config 不存在，无法进行登录操作，请确保运行文件夹中存在 sys.config 配置文件");
                this.Close();
            }
            else
            {
                Log.Debug("重要配置文件 sys.config 存在");
                Common.LoadConfigParameter();
            }



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //generalTimer.Start();

           
            txtCurrentUser.Text = GlobalData.UserType;
            //txtCurrentRecipe.Text = GlobalData.RecipeName;
            //txtType.Text = TypeTransform();
            txtSystemStatus.Text = "系统完成初始化";
        }


        public void HandlingPLCData(object sender, EventArgs e)
        {
            // 主页面启动时调用接收PLC数据函数，一直等待接收，接收到数据则进行处理

            // 建立3个线程，分别处理3个PLC的数据

            // plc1负责处理测径PLC数据
            Thread plc1Thread = new Thread(new ParameterizedThreadStart(plc1DealingThread));
            plc1Thread.Name = "PLC1 Data Dealing";
            plc1Thread.IsBackground = true;
            plc1Thread.Start();

        }

        private void plc1DealingThread(object sender)
        {
            while (true)
            {
                // 查询是否有PLC数据发送过来

                // 第一步：读取PLC1数据
                ReadPlc1();
                // 第二步：解析PLC1收到的数据， 根据不同的工序分别进行处理及应答

                Thread.Sleep(300);


                //break;
            }
        }



        private void itemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemAboutSystem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void itemChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Show();
        }

        private void itemChangeUser_Click(object sender, EventArgs e)
        {
            ChangeUserForm changeUserForm = new ChangeUserForm();
            changeUserForm.Show();
        }


        private void itemSetParameter_Click(object sender, EventArgs e)
        {
            SetParameterForm setParameterForm = new SetParameterForm();
            setParameterForm.Show();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseOperation();

            this.Close();
        }

        private void CloseOperation()
        {
            ClosePlc();
            MysqlOperation.DisconnectDb();
            /*
            CommonSerialPortControl.CloseSerialPort();
            DbOperation.DisconnectDb();
            */
        }

        private void btnSelectRecipeOk_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }



        private void OpenPlc(object sender, EventArgs e)
        {
            // 实例化对象，指定测径PLC的ip地址和端口号
            sieMeasure = new SiemensS7Net(SiemensPLCS.S1200, GlobalData.MeasurePlcIpAddress);

            // 连接对象
            OperateResult connect = sieMeasure.ConnectServer();
            if (!connect.IsSuccess)
            {
                MessageBox.Show("connect failed:" + connect.Message);
                Log.Error("PLC连接失败");
                return;
            }
            else
            {
                Log.Debug("PLC连接成功");
            }
           

        }

        private void ClosePlc()
        {
            try
            {
                sieMeasure.ConnectClose();

            }
            catch (Exception e)
            {
                Log.Warning(e.Message);
            }
        }

        //
        private void ReadPlc1()
        {

            // 读取PLC测径数据
            OperateResult<byte[]> read = sieMeasure.Read(GlobalData.DbNumber, UInt16.Parse(GlobalData.MeasureStructLength));
            OperateResult<byte[]> readPartData;
            //Log.Debug("read.Content.Length = " + read.Content.Length);
            OperateResult write;



            Measuring workpiece = new Measuring();
            NewPartData partData = new NewPartData();

            if (read.IsSuccess)
            {
                
                workpiece.stepNr = sieMeasure.ByteTransform.TransInt16(read.Content, 0);
                workpiece.stepNrCopy = sieMeasure.ByteTransform.TransInt16(read.Content, 2);
                Log.Debug("workpiece.stepNr = " + workpiece.stepNr + ", workpiece.stepNrCopy = " + workpiece.stepNrCopy);
                if (workpiece.stepNr == 1)
                {
                    readPartData = sieMeasure.Read(GlobalData.DbRecheckNumber, UInt16.Parse(GlobalData.RecheckStructLength));
                    if (readPartData.IsSuccess)
                    {
                        partData.resultP1 = sieMeasure.ByteTransform.TransInt16(readPartData.Content, 0);
                        partData.resultP1 = sieMeasure.ByteTransform.TransInt16(readPartData.Content, 2);
                        Log.Debug("partData.resultP1 = " + partData.resultP1);
                        Log.Debug("partData.resultP2 = " + partData.resultP2);

                        // 第2个字节表示此次发送的实际有效长度，对于string类型变量，不是每次都需要把整个256个字节读出来
                        ushort testP10Len = sieMeasure.ReadByte("DB421.5").Content;
                        partData.testP10 = sieMeasure.ReadString("DB421.4", testP10Len).Content;

                        ushort testP11Len = sieMeasure.ReadByte("DB421.261").Content;
                        partData.testP11 = sieMeasure.ReadString("DB421.260", testP11Len).Content;

                        ushort testP12Len = sieMeasure.ReadByte("DB421.517").Content;
                        partData.testP12 = sieMeasure.ReadString("DB421.516", testP12Len).Content;

                        ushort testP13Len = sieMeasure.ReadByte("DB421.773").Content;
                        partData.testP13 = sieMeasure.ReadString("DB421.772", testP13Len).Content;

                        ushort testP14Len = sieMeasure.ReadByte("DB421.1029").Content;
                        partData.testP14 = sieMeasure.ReadString("DB421.1028", testP14Len).Content;

                        Log.Debug(  "testP10Len = " + testP10Len +
                                    "testP11Len = " + testP11Len +
                                    "testP12Len = " + testP12Len +
                                    "testP13Len = " + testP13Len +
                                    "testP14Len = " + testP14Len);

                        Log.Debug(partData.testP10);
                        Log.Debug(partData.testP11);
                        Log.Debug(partData.testP12);
                        Log.Debug(partData.testP13);
                        Log.Debug(partData.testP14);

                        ushort testP20Len = sieMeasure.ReadByte("DB421.1285").Content;
                        partData.testP20 = sieMeasure.ReadString("DB421.1284", testP20Len).Content;

                        ushort testP21Len = sieMeasure.ReadByte("DB421.1541").Content;
                        partData.testP21 = sieMeasure.ReadString("DB421.1540", testP21Len).Content;

                        ushort testP22Len = sieMeasure.ReadByte("DB421.1797").Content;
                        partData.testP22 = sieMeasure.ReadString("DB421.1796", testP22Len).Content;

                        ushort testP23Len = sieMeasure.ReadByte("DB421.2053").Content;
                        partData.testP23 = sieMeasure.ReadString("DB421.2052", testP23Len).Content;

                        ushort testP24Len = sieMeasure.ReadByte("DB421.2309").Content;
                        partData.testP24 = sieMeasure.ReadString("DB421.2308", testP24Len).Content;

                        Log.Debug(  "testP20Len = " + testP20Len +
                                    "testP21Len = " + testP21Len +
                                    "testP22Len = " + testP22Len +
                                    "testP23Len = " + testP23Len +
                                    "testP24Len = " + testP24Len);

                        Log.Debug(partData.testP20);
                        Log.Debug(partData.testP21);
                        Log.Debug(partData.testP22);
                        Log.Debug(partData.testP23);
                        Log.Debug(partData.testP24);

                        partData.resultP11 = sieMeasure.ByteTransform.TransInt16(readPartData.Content, 2564);
                        partData.resultP22 = sieMeasure.ByteTransform.TransInt16(readPartData.Content, 2566);
                        Log.Debug("partData.resultP11 = " + partData.resultP11);
                        Log.Debug("partData.resultP22 = " + partData.resultP22);

                        ushort qrCodeP1Len = sieMeasure.ReadByte("DB421.2569").Content;
                        partData.qrCodeP1 = sieMeasure.ReadString("DB421.2568", qrCodeP1Len).Content;
                        Log.Debug("qrCodeP1Len = " + qrCodeP1Len + ", qrCodeP1:" + partData.qrCodeP1);

                        ushort qrCodeP2Len = sieMeasure.ReadByte("DB421.2825").Content;
                        partData.qrCodeP2 = sieMeasure.ReadString("DB421.2824", qrCodeP2Len).Content;
                        Log.Debug("qrCodeP2Len = " + qrCodeP2Len + ", qrCodeP2:" + partData.qrCodeP2);

                        /*
                        Log.Debug("acw_len: " + acw_len + ", dcw_len: " + dcw_len + ", ir_len: " + ir_len +
                            ",qr1_len: " + qr1_len + ",qr2_len" + qr2_len);

                        string[] acw_split = partData.acw.Split(',');
                        Log.Debug("acw_split length is " + acw_split.Length.ToString());
                        if (acw_split.Length >= 6)
                        {
                            partData.acw_result = acw_split[2].Trim();
                            partData.acw_voltage = acw_split[3].Trim();
                            partData.acw_current = acw_split[4].Trim();
                            partData.acw_time = acw_split[5].Trim();
                        }

                        string[] dcw_split = partData.dcw.Split(',');
                        Log.Debug("dcw_split length is " + dcw_split.Length.ToString());
                        if (dcw_split.Length >= 6)
                        {
                            partData.dcw_result = dcw_split[2].Trim();
                            partData.dcw_voltage = dcw_split[3].Trim();
                            partData.dcw_current = dcw_split[4].Trim();
                            partData.dcw_time = dcw_split[5].Trim();
                        }

                        Log.Debug("partData.result = " + partData.result);
                        Log.Debug("partData.ir = " + partData.ir);
                        Log.Debug("partData.qrCode1 = " + partData.qrCode1);
                        Log.Debug("partData.qrCode2 = " + partData.qrCode2);


                        Log.Debug("partData.acw_result =" + partData.acw_result
                                + ", partData.acw_voltage = " + partData.acw_voltage
                                + ", partData.acw_current = " + partData.acw_current
                                + ", partData.acw_time = " + partData.acw_time);
                        Log.Debug("partData.dcw_result =" + partData.dcw_result
                                + ", partData.dcw_voltage = " + partData.dcw_voltage
                                + ", partData.dcw_current = " + partData.dcw_current
                                + ", partData.dcw_time = " + partData.dcw_time);

                        */


                        //short val = 1;
                        write = sieMeasure.Write(GlobalData.DbNumberCopy, (short)1);

                        if (write.IsSuccess == false)
                        {
                            // Write PLC bool failed
                            string err = write.Message;
                            MessageBox.Show("Write (short)1 to DB420.2 second 2 byte failed, error: " + err);
                            Log.Error("Write (short)1 to DB420.2 second 2 byte failed, error: " + err);
                           
                        }
                        else
                        {
                            //MessageBox.Show("Write to DB420.2 second 2 byte ok");
                            Log.Info("Write to DB420 first 2 byte ok");
                        }

                        string sql = "";
                        //
                        
                        // 将读取到的PLC数据存入数据库
                        sql = String.Format("INSERT INTO tbl_part_data(resultP1, resultP2, testP10, testP11, testP12, testP13, testP14, testP20, testP21, testP22, testP23, testP24, resultP11, resultP22,  qrCodeP1, qrCodeP2) " +
                            "VALUES({0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\")", 
                            partData.resultP1, partData.resultP2, 
                            partData.testP10, partData.testP11, partData.testP12, partData.testP13, partData.testP14,
                            partData.testP20, partData.testP21, partData.testP22, partData.testP23, partData.testP24,
                            partData.resultP11, partData.resultP22,
                            partData.qrCodeP1, partData.qrCodeP2);
                        //
                        Log.Debug("Sql command ====> " + sql);
                        bool ret = MysqlOperation.ExecuteSqlCommand(sql);
                        if (!ret)
                        {
                            Log.Error("Insert MySQL error");
                        }    

                    }
                    else
                    {
                        //MessageBox.Show("Read PLC Data Error");

                        Log.Error("Read PLC PartData Error");
                        return;
                    }

                }
                else if (workpiece.stepNr == 0)
                {
                    write = sieMeasure.Write(GlobalData.DbNumberCopy, (short)0);

                    if (write.IsSuccess == false)
                    {
                        // Write PLC bool failed
                        string err = write.Message;
                        MessageBox.Show("Write (short)0 to DB420.2 second 2 byte failed, error: " + err);
                        Log.Error("Write (short)0 to DB420.2 second 2 byte failed, error: " + err);

                    }
                    else
                    {
                        //MessageBox.Show("Write to DB420.2 second 2 byte ok");
                        Log.Info("Write to DB420 first 2 byte ok");
                    }
                }
              

            }
            else
            {
                //MessageBox.Show("Read PLC Data Error");
                
                Log.Warning("Read PLC Data Error");
                return;
            }

        }
        //

        private void btnWritePLC2_Click(object sender, EventArgs e)
        {
            // 按地址偏移量写DB块
            byte[] value = new byte[263];
            short varShort = 345;
            int varInt = 9876;
            string varStr = "This is from Jiaxing";
            byte varByte = 0xCD;
            sieMeasure.Write("DB1.6", (short)varShort);
            sieMeasure.Write("DB1.8", (int)varInt);
            sieMeasure.Write("DB1.12", varStr);
            sieMeasure.Write("DB1.268", varByte);
        }

        private void generalTimer_Tick(object sender, EventArgs e)
        {
            txtCurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }



        private void btnReadPLC_Click(object sender, EventArgs e)
        {
            // 读取PLC测径数据
            OperateResult<byte[]> read = sieMeasure.Read(GlobalData.DbNumber, UInt16.Parse(GlobalData.MeasureStructLength));
            Log.Debug("read.Content.Length = " + read.Content.Length);




            Measuring workpiece = new Measuring();

            if (read.IsSuccess)
            {

                workpiece.stepNr = sieMeasure.ByteTransform.TransInt16(read.Content, 0);

                Log.Debug("stepNr value is " + workpiece.stepNr);
                MessageBox.Show("stepNr value is " + workpiece.stepNr);
                //Log.Debug("dint value is " + workpiece.stationId);
                //Log.Debug("plcFlag value is " + plcFlag);


            }
        }

        private void btnWritePLC_Click(object sender, EventArgs e)
        {
            string shortAddress1 = GlobalData.DbNumberCopy;
            short val = 678;
            OperateResult write = sieMeasure.Write(shortAddress1, val);
            
            if (write.IsSuccess == false)
            {
                // Write PLC bool failed
                string err = write.Message;
                MessageBox.Show(err);
                Log.Warning(err);
            }
            else
            {
                MessageBox.Show("Write to DB420 first 2 byte ok");
                Log.Info("Write to DB420 first 2 byte ok");
            }
        }

        private void btnConnectMysql_Click(object sender, EventArgs e)
        {
            PartData partData;
            partData.result = 1;
            partData.acw = "acw";
            partData.dcw = "dcw";
            partData.ir = "ir";
            partData.qrCode1 = "qrCode1";
            partData.qrCode2 = "qrCode2";
            partData.acw_result = "Pass";
            partData.acw_voltage = "1.5kV";
            partData.acw_current = "0.156mA";
            partData.acw_time = "1.0s";
            partData.dcw_result = "Fail";
            partData.dcw_voltage = "3.5kV";
            partData.dcw_current = "0.1uA";
            partData.dcw_time = "2.0s";

            string sql = String.Format("INSERT INTO tbl_part_data(result, acw, dcw, ir, qr_code1, qr_code2, acw_result, acw_voltage, acw_current, acw_time, dcw_result, dcw_voltage, dcw_current, dcw_time) " +
                          "VALUES({0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\",\"{13}\")",
                          partData.result, partData.acw, partData.dcw, partData.ir, partData.qrCode1, partData.qrCode2,
                          partData.acw_result, partData.acw_voltage, partData.acw_current, partData.acw_time,
                          partData.dcw_result, partData.dcw_voltage, partData.dcw_current, partData.dcw_time);
            MysqlOperation.ExecuteSqlCommand(sql);

        }

        private void btnGBDControl_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server = 127.0.0.1;uid=root;" + "pwd=spzhu;database=dbspzhu";

            //string sqlCommand = @"SELECT * FROM tbl_part_data INTO OUTFILE 'D:\\part_data2.csv' FIELDS TERMINATED BY ',' ENCLOSED BY '\"' LINES TERMINATED BY '\n'";
            string sqlCommand = @"SELECT * FROM tbl_part_data INTO OUTFILE 'D:\\part_data3.csv' FIELDS TERMINATED BY ','";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand(sqlCommand, conn);
                int ret = cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.StackTrace);
            }
        }

        private void btnReadFromDB_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (rbAll.Checked)
            {
                sql = "select * from tbl_part_data order by created_time desc limit 15;";
            }
            else if (rbPass.Checked)
            {
                sql = "select * from tbl_part_data where result = 1 order by created_time desc limit 15;";
            }
            else if (rbFail.Checked)
            {
                sql = "select * from tbl_part_data where result = 0 order by created_time desc limit 15;";
            }
            
            
            Log.Debug("Sql command ====> " + sql);
            string readResult = MysqlOperation.SelectCommand(sql);
            Log.Debug("Read qr_code info: " + readResult);
            txtQrCodeInfo.Text = readResult;
            
        }

        private void btnQueryBasedOnQrCode_Click(object sender, EventArgs e)
        {
            string sql = "";
            string strQrCode1 = txtQrCode1.Text.ToString().Trim();
            string strQrCode2 = txtQrCode2.Text.ToString().Trim();
            if (strQrCode1 != String.Empty)
            {
                sql = "select * from tbl_part_data where qr_code = '" + strQrCode1 + "' limit 1;";
            }


            Log.Debug("Sql command ====> " + sql);
            string readResult = MysqlOperation.SelectCommand(sql);
            if (readResult != String.Empty)
            {
                Log.Debug("Read qr_code info: " + readResult);
                txtQrCodeInfo.Text = readResult;
            }
            else
            {
                Log.Debug("Read qr_code info is empty");
                MessageBox.Show("查询结果为空");
            }

        }
    }

    
}
