using BWM01;
using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBD
{
    public partial class CommunicationForm : Form
    {
        public CommunicationForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPingTest_Click(object sender, EventArgs e)
        {
            bool pingable = false;
            Ping pinger = null;

            IPAddress ip;
            bool b = IPAddress.TryParse(txtIpAddress.Text, out ip);
            if (b == false)
            {
                MessageBox.Show("IP 地址输入有误，请重新输入");
                return;
            }


            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(ip);
                pingable = (reply.Status == IPStatus.Success);
                MessageBox.Show("Ping result: " + pingable);
            }
            catch(PingException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }

            }
        }

        private void btnChainTest_Click(object sender, EventArgs e)
        {
            // Create a request for the URL. 		
            //WebRequest request = WebRequest.Create("http://www.baidu.com/index.html");
            WebRequest request = WebRequest.Create("https://baas-test.vechaindev.com/");

            request.ContentType = "application/json";

            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Log.Debug(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Log.Debug(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
        }


        // 获取时间戳
        public string GetTimeStamp(DateTime time)
        {
            long ts = ConvertDateTimeToInt(time);
            return ts.ToString();
        }

        // DateTime时间格式转换为Unix时间戳格式
        public long ConvertDateTimeToInt(DateTime time)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = (time.Ticks - startTime.Ticks) / 10000;  // 除以 10000 调整为13位
            return t;
        }

      

        private void OpenPLC1_Click(object sender, EventArgs e)
        {

        }

        private void btnReadPLC1_Click(object sender, EventArgs e)
        {
            Plc plc = new Plc(CpuType.S71500, "192.168.0.40", 0, 1);

            if (plc.IsConnected == true)
            {
                Log.Debug("PLC connected");
            }
            else
            {
                MessageBox.Show("PLC connection failed");
                Log.Error("PLC connection failed");
                return;
            }


            short result = ((ushort)plc.Read("DB18.DBW0")).ConvertToShort();
            MessageBox.Show(result.ToString());
            plc.Close();
        }
    }
}
