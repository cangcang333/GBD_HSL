using GBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BWM01
{
    static class DbOperation
    {
        static SqlConnection sqlConnection;
        static SqlCommand sqlCommand;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);
        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static bool ConnectDb()
        {
            // 获取连接数据库需要的配置信息
            StringBuilder temp = new StringBuilder(500);
            string section = "SQL Server 2008 Configuration";
            string key = "Data Source";
            string def = "";
            string filePath = Environment.CurrentDirectory + @"\Config\sys.config";

            long i = GetPrivateProfileString(section, key, def, temp, 500, filePath);
            string dataSource = temp.ToString();

            key = "Initial Catalog";
            i = GetPrivateProfileString(section, key, def, temp, 500, filePath);
            string initialCatalog = temp.ToString();

            key = "User ID";
            i = GetPrivateProfileString(section, key, def, temp, 500, filePath);
            string userID = temp.ToString();

            key = "Pwd";
            i = GetPrivateProfileString(section, key, def, temp, 500, filePath);
            string pwd = temp.ToString();

            // 建立数据库连接
            string connectionInfo = "Data Source=" + dataSource + ";Initial Catalog=" + initialCatalog + ";User ID=" + userID + ";Pwd=" + pwd;
            Log.Debug(connectionInfo);
            sqlConnection = new SqlConnection(connectionInfo);
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Log.Error("连接数据库失败");
                Log.Error(ex.Message);
                Log.Error(ex.StackTrace);
                Log.Error(ex.Source);
                return false;
            }

            Log.Info(sqlConnection.State.ToString());

            
            if (sqlConnection.State == ConnectionState.Open)
            {
                Log.Debug("连接数据库成功");
                return true;
            }
            else
            {
                MessageBox.Show("连接数据库失败");
                Log.Error("连接数据库失败");
                return false;
            }

        }

        public static void DisconnectDb()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        public static bool ExecuteSqlCommand(string sql)
        {
            //TODO: 添加异常处理（try-catch-finally）
            try
            {
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = sql;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                Log.Warning(e.StackTrace);
                return false;
            }
            //DisconnectDb();

            return true;
        }

     


        public static void ReadSingleRow(IDataRecord record)
        {
            MessageBox.Show(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}", 
                record[0], record[1], record[2], record[3], record[4], record[5], record[6], record[7], record[8], record[9], record[10], record[11], record[12], record[13], record[14], record[15]));

            Log.Debug(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}",
                record[0], record[1], record[2], record[3], record[4], record[5], record[6], record[7], record[8], record[9], record[10], record[11], record[12], record[13], record[14], record[15]));

        }

    }
}
