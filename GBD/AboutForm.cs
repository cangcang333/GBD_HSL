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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            txtVersion.Text = GlobalData.version.ToString();
            txtIssueDate.Text = String.Format("{0} 年 {1} 月 {2}日", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            
            txtOwner.Text = GlobalData.systemOwner;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
