using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBD
{
    static class GlobalData
    {
        public static double version = 0.1;
        public static string systemOwner = "浙江秉鹏自动化科技有限公司";

        public static string RecipeName = "";
        public static string UserType = "";

        // 参数设置全局变量

        // 全局重要参数


        public static ushort Type;         // 单载体为1，双载体为2

        // 测径PLC参数
        public static string MeasurePlcIpAddress = "192.168.0.10";
        public static string DbNumber = "DB420.0";
        public static string MeasureStructLength = "4";
        public static string DbNumberCopy = "DB420.2";

        // 复测PLC参数
        public static string RecheckPlcIpAddress = "192.168.0.10";
        public static string DbRecheckNumber = "DB421.0";
        //public static string RecheckStructLength = "266";
        public static string RecheckStructLength = "3080";



        //public static string dbNumber = "DB10";
        public static string dbStartOffset = "0";
        public static string boolVariableNum = "400";
        public static string intVariableNum = "100";
        public static string realVariableNum = "100";
        public static string dintVariableNum = "100";

        //  串口相关参数
        public static bool IsSerialPortOpen = false;

    }




    public struct PartData
    {
        // PLC 数据块
        public short result;           // DB421.0 （0 - uninitialized, 1 - ok, 2 - not ok）
        public string acw;             // DB421.2
        public string dcw;             // DB421.258
        public string ir;             // DB421.514

        
        public string qrCode1;         // DB421.770
        public string qrCode2;         // DB421.1026
        public string reserved;        // DB421.1282  (string type default length 254)

        public string acw_result;     // "Pass" or "Fail"
        public string acw_voltage;    
        public string acw_current;    // uA     
        public string acw_time;       // unit: Second

        public string dcw_result;     // "Pass" or "Fail"
        public string dcw_voltage;
        public string dcw_current;    // uA     
        public string dcw_time;       // unit: Second

    }

    public struct Measuring
    {
        // 与PLC交互DB块
        public short stepNr;         // DB420.0
        public short stepNrCopy;     // DB420.2
        public string reserved;      // DB420.4
    }


    public struct NewPartData
    {
        // PLC 数据块
        // FinallyData01

        public short resultP1;           // DB421.0.0 （0 - uninitialized, 1 - ok, 2 - not ok）
        public short resultP2;           // DB421.2.0 （0 - uninitialized, 1 - ok, 2 - not ok）

        // TestP1
        public string testP10;           // DB421.4.0
        public string testP11;           // DB421.260.0
        public string testP12;           // DB421.516.0
        public string testP13;           // DB421.772.0
        public string testP14;           // DB421.1028.0
        // TestP2
        public string testP20;           // DB421.1284.0
        public string testP21;           // DB421.1540.0
        public string testP22;           // DB421.1796.0
        public string testP23;           // DB421.2052.0
        public string testP24;           // DB421.2308.0

        // FinallyData01
        public short resultP11;           // DB421.2564.0 （0 - uninitialized, 1 - ok, 2 - not ok）
        public short resultP22;           // DB421.2566.0 （0 - uninitialized, 1 - ok, 2 - not ok）

        public string qrCodeP1;           // DB421.2568.0
        public string qrCodeP2;           // DB421.2824.0


    }

}
