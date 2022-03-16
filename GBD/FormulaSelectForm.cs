using GBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BWM01
{
    public partial class FormulaSelectForm : Form
    {

        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        public FormulaSelectForm()
        {
            InitializeComponent();

            formulaSelectCombo.SelectedIndex = 0;
            Cancel.Enabled = false;


        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            // 加载选择好的配方数据进行加载
            // GlobalData.RecipeName 保持为最新的配方名
            string recipeName = formulaSelectCombo.Text;


       

            //this.Close();
        }
    }
}
