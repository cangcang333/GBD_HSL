using GBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BWM01
{
    public static class Common
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileStringW(string section, string key, string value, string filePath);
        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        static string configFilePath = string.Empty;
        static string recipeFilePath = string.Empty;

        private static long frequency;



        public static int ConfigFileCheck()
        {
            int ret = Constants.FAILURE;

            // 检查配置文件 sys.config 是否存在，若不存在，返回错误
            string filePath = Environment.CurrentDirectory + @"\Config\sys.config";
            if (File.Exists(filePath) == true)
            {
                configFilePath = filePath;
                ret = Constants.SUCCESS;
            }
            else
            {
                Log.Error("配置文件 sys.config 不存在，请检查");

            }

            return ret;
        }

        public static int RecipeFileCheck(string recipeName)
        {
            int ret = Constants.FAILURE;

            // 检查配置文件 sys.config 是否存在，若不存在，返回错误
            string filePath = Environment.CurrentDirectory + @"\Config\" + recipeName + ".ini";
            if (File.Exists(filePath) == true)
            {
                recipeFilePath = filePath;
                ret = Constants.SUCCESS;
            }
            else
            {
                Log.Error("配方文件" + filePath + "不存在，请检查");

            }

            return ret;
        }

        public static string GetConfigValue(string section, string key)
        {
            string value = "";
            StringBuilder temp = new StringBuilder(500);
            string def = "";

            //string filePath = Environment.CurrentDirectory + @"\Config\sys.config";

            long i = GetPrivateProfileString(section, key, def, temp, 500, configFilePath);
            value = temp.ToString();

            return value;
        }

        public static long WriteConfigValue(string section, string key, string value)
        {
            //string filePath = Environment.CurrentDirectory + @"\Config\sys.config";

            long i = WritePrivateProfileString(section, key, value, configFilePath);
            return i;
        }

        public static string GetRecipeValue(string section, string key, string recipeName)
        {
            string value = "";
            StringBuilder temp = new StringBuilder(500);
            string def = "";
            string filePath = Environment.CurrentDirectory + @"\Config\" + recipeName + ".ini";

            long i = GetPrivateProfileString(section, key, def, temp, 500, filePath);
            value = temp.ToString();
            Log.Debug("GetRecipeValue value = " + value);
            return value;
        }

        public static long WriteRecipeValue(string section, string key, string value, string recipeName)
        {
            string filePath = Environment.CurrentDirectory + @"\Config\" + recipeName + ".ini";
            //Log.Debug("WriteRecipeValue shit filePath : " + filePath);

            long i = WritePrivateProfileString(section, key, value, filePath);
            return i;
        }



        // MD5 方法加密
        public static string MD5Encrypt64(string encryptString)
        {
            string returnString = "";

            string str = encryptString;
            MD5 md5 = MD5.Create();
            byte[] b = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            returnString = Convert.ToBase64String(b);

            return returnString;
        }

        // 从 sys.config 配置文件中获取各种用户类型密码
        public static string GetUserPassword(string userType)
        {
            string key = "";
            StringBuilder temp = new StringBuilder(500);
            string section = "Login User Password";
            if (userType.Equals("操作员"))
            {
                key = "Operator Password";
            }
            else if (userType.Equals("工程师"))
            {
                key = "Engineer Password";
            }
            else
            {
                return string.Empty;
            }
            string def = "";
            //string filePath = Environment.CurrentDirectory + @"\Config\sys.config";

            // TODO
            // 需要先检查 filePath 是否存在


            long i = GetPrivateProfileString(section, key, def, temp, 500, configFilePath);

            return temp.ToString();
        }

        // 更新 sys.config 配置文件中各种用户类型的密码
        public static long UpdatePassword(string userType, string encryptNewPassword)
        {
            string key = "";
            string section = "Login User Password";
            if (userType.Equals("操作员"))
            {
                key = "Operator Password";
            }
            else if (userType.Equals("工程师"))
            {
                key = "Engineer Password";
            }
            else
            {
                return -1;
            }
            //string filePath = Environment.CurrentDirectory + @"\Config\sys.config";
            long i = WritePrivateProfileString(section, key, encryptNewPassword, configFilePath);

            return i;
        }

        private static byte[] Keys = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };
        private static string encryptKey = "abcdefgh";

        // DES 加密
        public static string DESEncrypt64(string encryptString)
        {
            string returnString = "";

            byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            //des.Key = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
            //des.IV = Keys;
            byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
            byte[] rgbIV = Keys;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            returnString = Convert.ToBase64String(ms.ToArray());

            //StringBuilder sb = new StringBuilder();
            //foreach (byte by in ms.ToArray())
            //{
            //    sb.AppendFormat("{0:X2}", by);
            //}

            //returnString = sb.ToString();

            return returnString;
        }

        // DES 解密
        public static string DESDecrypt64(string decryptString)
        {
            string returnString = "";

            byte[] inputByteArray = Convert.FromBase64String(decryptString);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            //des.Key = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
            //des.IV = Keys;
            byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
            byte[] rgbIV = Keys;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            returnString = Encoding.UTF8.GetString(ms.ToArray());

            return returnString;
        }


        public static int getTimeTick()
        {
            return Environment.TickCount;
        }



        public static void AccurateSleep(int milliseconds)
        {
            long startCount = 0;
            long endCount = 0;
            double passedSeconds = 0.0;

            if (QueryPerformanceFrequency(out frequency) == false)
            {
                // Do not support high performance counter
                throw new Win32Exception();
            }


            QueryPerformanceCounter(out startCount);
            do
            {
                QueryPerformanceCounter(out endCount);
                passedSeconds = (double)(endCount - startCount) / (double)frequency * 1000;
            } while (passedSeconds < milliseconds);

        }




        public static int LoadConfigParameter()
        {
            int ret = Constants.FAILURE;

            // 参数设置页面参数
            // 串口号
            //GlobalData.ChopperUseCount = Convert.ToInt32(Common.GetConfigValue("Hardware Info", "ChopperUseCount"));

            return ret;
        }

    }
}
