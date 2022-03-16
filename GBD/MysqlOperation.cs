using BWM01;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBD
{
    static class MysqlOperation
    {
        static MySql.Data.MySqlClient.MySqlConnection conn;
        public static bool ConnectDb()
        {
            string myConnectionString;
            myConnectionString = "server = 127.0.0.1;uid=root;" + "pwd=spzhu;database=dbspzhu";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                bool status = conn.Ping();
                if (status == true)
                {
                    Log.Debug("Ping ok");
                    return true;
                }
                else
                {
                    Log.Warning("Ping failed");
                    return false;
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Log.Error(ex.Message);
                return false;
            }
        }

        public static void DisconnectDb()
        {
            conn.Close();

        }

        public static bool ExecuteSqlCommand(string sqlCommand)
        {
            // INSERT 命令
            //
            PartData partData = new PartData();
            partData.result = 1;


            //string sqlCommand = String.Format("INSERT INTO tbl_part_data(result, voltage, current, time, qr_code) VALUES({0}, {1}, {2}, {3}, \"{4}\")",partData.result, partData.voltage, partData.current, partData.time, partData.qrCode);
            //Log.Debug("sqlCommand: [" + sqlCommand + "]");

            MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
            int ret = cmd.ExecuteNonQuery();
            
            if (ret != 0)
            {
                // 判断SQL INSERT 结果
                Log.Debug("ret = " + ret);
                return true;
            }
            else
            {
                Log.Error("Insert failed, ret = " + ret);
                return false;
            }

        }

        public static string SelectCommand(string sqlCommand)
        {
            // INSERT 命令
            //
            NewPartData partData = new NewPartData();
            string readResult = "";
            int recordCnt = 0;

            MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
            int ret = cmd.ExecuteNonQuery();

            var reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                string qr_code = (string)reader["qr_code"];
                int id = (int)reader["id"];
                int result = (int)reader["result"];
                decimal vol = (decimal)reader["voltage"];
                System.DateTime mysql_updated_time = (System.DateTime)reader["updated_time"];

                /*
                // just to shorten the code
                var isoDateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;
                string updated_time = mysql_updated_time.ToString(isoDateTimeFormat.SortableDateTimePattern);
                */

                readResult += "id:[" + id + "], qr_code:[" + qr_code + "], result:[" + result + "], updated_time:[" + mysql_updated_time + "]" + Environment.NewLine;
                recordCnt++;
            }

            reader.Close();

            Log.Debug("recordCnt = " + recordCnt);
            

            if (ret != 0)
            {
                // 判断SQL INSERT 结果
                Log.Debug("ret = " + ret);
                return readResult;
            }
            else
            {
                Log.Error("Select failed, ret = " + ret);
                return readResult;
            }

        }
    }
}
