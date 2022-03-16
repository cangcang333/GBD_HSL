using BWM01;
using GBDGetLaserData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBD
{
    public static class KeyenceControl
    {
        [DllImport("wsock32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        extern public static int inet_addr([MarshalAs(UnmanagedType.VBByRefStr)] ref string cp);


        // Return Code List
        internal enum RC
        {
            RC_OK = 0x0, // The operation is completed successfully.
            //''''''''''''''''''''''
            // Communication error from controller notification
            //
            RC_NAK_COMMAND = 0x1001, // Command error
            RC_NAK_COMMAND_LENGTH = 0x1002, // Command length error
            RC_NAK_TIMEOUT = 0x1003, // Timeout
            RC_NAK_CHECKSUM = 0x1004, // Check sum error
            RC_NAK_INVALID_STATE = 0x1005, // Status error
            RC_NAK_OTHER = 0x1006, // Other error
            RC_NAK_PARAMETER = 0x1007, // Parameter error
            RC_NAK_OUT_STAGE = 0x1008, // OUT calculation count limitation error
            RC_NAK_OUT_HEAD_NUM = 0x1009, // No. of used head/OUT over error
            RC_NAK_OUT_INVALID_CALC = 0x100A, // OUT which cannot be used for calculation was specified for calculation.
            RC_NAK_OUT_VOID = 0x100B, // OUT which specified for calculation is not found.
            RC_NAK_INVALID_CYCLE = 0x100C, // Unavailable sampling cycle
            RC_NAK_CTRL_ERROR = 0x100D, // Main unit error
            RC_NAK_SRAM_ERROR = 0x100E, // Setting value error
            //''''''''''''''''''''''
            // Communication DLL error notification
            //
            RC_ERR_OPEN_DEVICE = 0x2000, // Opening the device failed.
            RC_ERR_NO_DEVICE = 0x2001, // The device is not open.
            RC_ERR_SEND = 0x2002, // Command sending error
            RC_ERR_RECEIVE = 0x2003, // Response receiving error
            RC_ERR_TIMEOUT = 0x2004, // Timeout
            RC_ERR_NODATA = 0x2005, // No data
            RC_ERR_NOMEMORY = 0x2006, // No free memory
            RC_ERR_DISCONNECT = 0x2007, // Cable disconnection suspected
            RC_ERR_UNKNOWN = 0x2008 // Undefined error
        }

        private static bool IsSuccess(LKIF2.RC returnCode)
        {
            bool result = false;
            if (returnCode == LKIF2.RC.RC_OK)
            {
                result = true;
            }
            return result;
        }

        private static void ShowSuccessMsg(string funcName, LKIF2.RC returnCode)
        {
            //txtResultText.Text = funcName + " is succeeded. RC = 0x" + ((int)returnCode).ToString("X");
            string resultText= funcName + " is succeeded. RC = 0x" + ((int)returnCode).ToString("X");
            Log.Debug(resultText);
        }

        private static void ShowFailureMsg(string funcName, LKIF2.RC returnCode)
        {
            string MessageText = "Failed in " + funcName + ". RC = 0x" + ((int)returnCode).ToString("X");
            Log.Debug(MessageText);

            /*
            if (chkIsDisplayMessageBox.CheckState == CheckState.Checked)
            {
                MessageBox.Show(MessageText, Application.ProductName);
            }
            txtResultText.Text = MessageText;
            */
        }

        private static bool FuncQuit(string funcName, LKIF2.RC returnCode)
        {
            if (IsSuccess(returnCode))
            {
                ShowSuccessMsg(funcName, returnCode);
                return true;
            }
            else
            {
                ShowFailureMsg(funcName, returnCode);
                return false;
            }
        }

        public static void btnOpenDeviceUSB_Click(object sender, EventArgs e)
        {
            FuncQuit("LKIF2_OpenDeviceUsb", LKIF2.LKIF2_OpenDeviceUsb());
        }



        private static string FloatResultValueOutToText(LKIF2.LKIF_FLOATVALUE_OUT FloatValue)
        {
            if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_VALID)
            {
                return FloatValue.value.ToString();
            }
            else if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_RANGEOVER_P)
            {
                return "+FFFFFFF";
            }
            else if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_RANGEOVER_N)
            {
                return "-FFFFFFF";
            }
            else if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_WAITING)
            {
                return "--------";
            }
            else if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_ALARM)
            {
                return "alarm";
            }
            else
            {
                return "Invalid";
            }
        }


        public static bool OpenDeviceEthernet(string ipAddres)
        {
            LKIF2.LKIF_OPENPARAM_ETHERNET openParam = new LKIF2.LKIF_OPENPARAM_ETHERNET();
            //example:"192.168.0.10"
            //string ipAddres = txtOpenDeviceEthernetIP.Text;

            //string ipAddres = GlobalData.MeasureLaserIp;
            openParam.IPAddress.S_addr = inet_addr(ref ipAddres);

            bool openResult = FuncQuit("LKIF2_OpenDeviceETHER", LKIF2.LKIF2_OpenDeviceETHER(ref openParam));
            if (openResult == true)
            {
                Log.Debug("Open Measure Laser Ethernet Successful");
                return true;
            }
            else
            {
                Log.Debug("Open Measure Laser Ethernet Failed");
                return false;
            }
        }


        public static void DataStorageStart()
        {
            // Step1: Initialize and clear data before
            FuncQuit("LKIF2_DataStorageInit", LKIF2.LKIF2_DataStorageInit());

            // Step2: Start store data
            FuncQuit("LKIF2_DataStorageStart", LKIF2.LKIF2_DataStorageStart());
        }

        public static void DataStorageEnd(string fileName)
        {
            // Step3: Stop store data
            FuncQuit("LKIF2_DataStorageStop", LKIF2.LKIF2_DataStorageStop());
            // Step4: Output data to csv file
            DataStorageGetData(fileName);
        }


        //private void DataStorageGetData_Click(Object eventSender, EventArgs eventArgs)
        public static void DataStorageGetData(string fileName)
        {
            int outNo = 0;
            int numOutBuffer = 10000;
            LKIF2.LKIF_FLOATVALUE[] OutBuffer = new LKIF2.LKIF_FLOATVALUE[1200001];
            int numReceived = 10000;

            LKIF2.RC result = (LKIF2.RC)0;

            result = LKIF2.LKIF2_DataStorageGetData(outNo, numOutBuffer, ref OutBuffer[0], ref numReceived);
            Log.Debug(String.Format("outNo = {0}, OutBuffer = {1}, numOutBuffer = {2}, numReceived = {3}", outNo, OutBuffer, numOutBuffer, numReceived));
            //MessageBox.Show(String.Format("outNo = {0}, OutBuffer = {1}, numOutBuffer = {2}, numReceived = {3}", outNo, OutBuffer, numOutBuffer, numReceived));


            if (IsSuccess(result))
            {

                if (true)
                {

                    try
                    {

                        string date = DateTime.Now.ToLocalTime().ToString("yyyyMMddHHmmss");

                        //string filePath = Environment.CurrentDirectory + @"\Csv\" + date + ".csv";
                        string filePath = Environment.CurrentDirectory + @"\Csv\" + fileName + ".csv";
                        Log.Debug("csv file path is: " + filePath);
                        StreamWriter writer = new StreamWriter(filePath);
                        /*
                        writer.WriteLine("OutNo");
                        writer.WriteLine(outNo);
                        writer.WriteLine("Data,FloatResult");
                        */
                        for (int cnt = 0; cnt <= numReceived - 1; cnt++)
                        {
                            writer.WriteLine(OutBuffer[cnt].value.ToString() + "," + FloatResultValueToText(OutBuffer[cnt]));
                        }
                        writer.Close();
                    }
                    catch
                    {
                        Log.Warning("Failed in saving the File.");
                    }
                }
            }
            FuncQuit("LKIF2_DataStorageGetStatus", result);
        }

        private static string FloatResultValueToText(LKIF2.LKIF_FLOATVALUE FloatValue)
        {
            if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_VALID)
            {
                return "LKIF_FLOATRESULT_VALID";
            }
            else if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_RANGEOVER_P)
            {
                return "LKIF_FLOATRESULT_RANGEOVER_P";
            }
            else if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_RANGEOVER_N)
            {
                return "LKIF_FLOATRESULT_RANGEOVER_N";
            }
            else if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_WAITING)
            {
                return "LKIF_FLOATRESULT_WAITING";
            }
            else if (FloatValue.FloatResult == LKIF2.LKIF_FLOATRESULT.LKIF_FLOATRESULT_ALARM)
            {
                return "LKIF_FLOATRESULT_ALARM";
            }
            else
            {
                return "LKIF_FLOATRESULT_INVALID";
            }
        }


    }
}
