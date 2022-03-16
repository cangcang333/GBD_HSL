using BWM01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBD
{
    public partial class LoginForm : Form
    {
        int loginCount = 0;

        public LoginForm()
        {
            InitializeComponent();
            Log.Init();
            userTypeCombo.SelectedIndex = 0;

            // 进行 Common.Init， 检查 sys.config 配置文件是否存在
            if (Constants.FAILURE == Common.ConfigFileCheck())
            {
                MessageBox.Show("重要配置文件 sys.config 不存在，无法进行登录操作，请确保运行文件夹中存在 sys.config 配置文件");
                Log.Error("重要配置文件 sys.config 不存在，无法进行登录操作，请确保运行文件夹中存在 sys.config 配置文件");
            }

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //
            // Get password from sys.config
            string password = string.Empty;
            password = Common.GetUserPassword(userTypeCombo.Text);
            Log.Debug("shit, sys.config password:" + password);

            string encryptPassword = Common.MD5Encrypt64(txtPassword.Text);
            Log.Info("用户类型为" + userTypeCombo.Text);
            Log.Info("用户输入密码加密后为" + encryptPassword);


            if (userTypeCombo.Text.Equals("操作员") && encryptPassword.Equals(password))
            {
                //GlobalData.UserType = "Operator";
                GlobalData.UserType = "操作员";
                LoginOperation();
            }
            else if (userTypeCombo.Text.Equals("工程师") && encryptPassword.Equals(password))
            {
                //GlobalData.UserType = "Engineer";
                GlobalData.UserType = "工程师";
                LoginOperation();
            }
            else
            {
                loginCount++;
                if (loginCount >= 10)
                {
                    MessageBox.Show("登录错误超过上限10次，程序退出！");
                    this.Close();
                }

                String str = "用户名或密码错误，登录第 " + String.Format("{0}", loginCount) + "次错误";
                MessageBox.Show(str);
            }

            //


        }

        // 登录成功后进行相关操作，包括记日志、记库、调用主页面
        private void LoginOperation()
        {
            // 登录次数清零
            loginCount = 0;

            // 用户登录记日志文件
            string loginOkMessage = userTypeCombo.Text + " 登录成功！";
            Log.Info(loginOkMessage);

            // 修改sys.config当前用户信息
            //Common.WriteConfigValue("Current Operation Info", "Current User", userTypeReal);

            GlobalData.UserType = userTypeCombo.Text;

            // 用户登录记库
            string sql = "insert into tbl_gbd_user_login (user_type, rec_crt_ts) values ('" + userTypeCombo.Text + "', getdate())";
            Log.Debug("Insert sql string is [" + sql + "]");

            /*
            DbOperation.ConnectDb();
            if (false == DbOperation.ExecuteSqlCommand(sql))
            {
                MessageBox.Show("登录用户密码正确，登录信息插入数据库失败，请注意查看日志，检查原因");
                Log.Error("登录用户密码正确，登录信息插入数据库失败，请注意查看日志，检查原因");

            }
            DbOperation.DisconnectDb();
            */


            this.Hide();


            // 调用主页面
            FormulaSelectForm formulaSelectForm = new FormulaSelectForm();
            formulaSelectForm.ShowDialog();

            this.Close();

        }
    }
}
