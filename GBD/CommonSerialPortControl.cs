using GBD;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BWM01
{
    public static class CommonSerialPortControl
    {
        // 定义端口类
        public static SerialPort ComDevice = new SerialPort();

        public static short accum;

        public static bool OpenSerialPort()
        {
            if (ComDevice.IsOpen == false)
            {
                // 设置串口相关属性
                ComDevice.PortName = "COM8";
                ComDevice.BaudRate = 9600;
                ComDevice.Parity = Parity.None;
                ComDevice.DataBits = 8;
                ComDevice.StopBits = StopBits.One;
                try
                {
                    ComDevice.Open();
                    Log.Debug(ComDevice.PortName + " 串口打开成功");

                }
                catch (Exception ex)
                {
                    Log.Error("串口打开失败");
                    return false;
                }

            }
            else
            {
                try
                {
                    // 关闭串口
                    ComDevice.Close();
                    Log.Debug(ComDevice.PortName + " 串口已被打开，关闭成功");
                    return false;
                }
                catch (Exception ex)
                {
                    Log.Error("串口已被打开且关闭失败");
                    return false;
                }
            }

            return true;
        }

        public static bool CloseSerialPort()
        {
            if (ComDevice.IsOpen == true)
            {
                try
                {
                    // 关闭串口
                    ComDevice.Close();
                    Log.Debug(ComDevice.PortName + " 串口关闭成功");
                }
                catch (Exception ex)
                {
                    Log.Error("串口关闭失败");
                    return false;
                }
            }
            else
            {

                Log.Debug(ComDevice.PortName + " 串口已被关闭");
            }

            return true;
        }

        public static byte[] HexStringToByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if (hexString.Length % 2 != 0)
            {
                hexString += " ";
            }
            byte[] returnByte = new byte[hexString.Length / 2];
            for (int i = 0; i < returnByte.Length; i++)
            {
                returnByte[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            }
            return returnByte;
        }

        public static string ByteToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.AppendFormat("{0:X2}" + " ", data[i]);
            }
            return sb.ToString().Trim();
        }



        public static bool SendData(byte[] data)
        {
            Log.Debug(String.Format("待发送数据[{0}]", ByteToHexString(data)));
            try
            {
                ComDevice.Write(data, 0, data.Length);
                return true;
            }
            catch (Exception ex)
            {
                Log.Error("数据发送失败");
            }

            return false;
        }


        public static string GetWeight(string request)
        {
            byte[] sendData = Encoding.ASCII.GetBytes(request.Trim());
            //SendData(sendData);

            ComDevice.WriteLine(request);

            string receiveData = "";
            //Common.AccurateSleep(300);
            Common.AccurateSleep(500);

            try
            {
                

                // 开辟接收缓冲区
                byte[] ReceiveData = new byte[ComDevice.BytesToRead];
                // 从串口读取数据
                ComDevice.Read(ReceiveData, 0, ReceiveData.Length);

                //ComDevice.ReadLine();

                // 实现数据的解码与显示
                receiveData = AddData(ReceiveData);
                receiveData = receiveData.Replace('g', ' ').Trim();
                Log.Info("receiveData = [" + receiveData + "]");

            }
            catch (Exception ex)
            {
                Log.Error("数据发送失败");
            }

            return receiveData;
        }

        public static string GetWeight2(string request)
        {
            byte[] sendData = Encoding.ASCII.GetBytes(request.Trim());
            ComDevice.WriteLine(request);

            string receiveData = "";
            //Common.AccurateSleep(500);

            try
            {
                // 实现数据的解码与显示
                receiveData = ComDevice.ReadExisting();
                Log.Info("receiveData = [" + receiveData + "]");

            }
            catch (Exception ex)
            {
                Log.Error("数据发送失败");
            }

            return receiveData;
        }

        public static string AddData(byte[] data)
        {
             return (new ASCIIEncoding().GetString(data));

        }


        public static string GetUltrasonicData(string sendContent)
        {
            string receiveData = "";
            
            if (GlobalData.IsSerialPortOpen == false)
            {
                Log.Warning("串口未打开，请检查设备情况");
                return null;
            }
            

            // 第二步：发送数据
            byte[] sendData = null;
            //string strSendData = "FA 02 11 A5 00 02 01 00 00 00 AA 7A 64";
            //string strSendData = "FA 02 11 A5 00 02 0F 00 08 00 32 00 00 00 00 00 00 00 AA 0F 03";
            //string strSendData = "FA 02 11 A5 00 01 0F 00 08 00 32 00 00 00 00 00 00 00 AA 0E E3";
            sendData = HexStringToByte(sendContent);

            SendData(sendData);

            Common.AccurateSleep(20);

            // 第三步：接收数据

            // 开辟接收缓冲区
            byte[] ReceiveData = new byte[ComDevice.BytesToRead];
            // 从串口读取数据
            ComDevice.Read(ReceiveData, 0, ReceiveData.Length);

            //receiveData = Encoding.UTF8.GetString(ReceiveData);

            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ReceiveData.Length; i++)
            {
                sb.AppendFormat("{0:X2}" + " ", ReceiveData[i]);
            }
            receiveData = sb.ToString();
            Log.Info("receiveData = [" + receiveData + "]");

            DataRefine(receiveData);
            
            return receiveData;
        }

        // 数据校验，如 FA 02 00 A5 11 82 0F 02 00 00 AA AA 68
        public static void DataRefine(string receiveData)
        {
            byte[] data = HexStringToByte(receiveData);
            for (int i = 0; i < data.Length; i++)
            {
                Log.Debug(String.Format("data[{0}] = {1:X2}", i, data[i]));
            }
            if (data[0].Equals(0xFA) && data[1].Equals(0x02) && data[6].Equals(0x0F))
            {
                if (data[7].Equals(0x00))
                {
                    Log.Debug("接收到有效数据");
                }
                else
                {
                    Log.Warning(String.Format("返回应答码为[{0:X2}]，请检查原因", data[7]));
                    return;
                }
            }
            else
            {
                Log.Warning("返回数据格式错误");
                return;
            }
        }

    }
}
