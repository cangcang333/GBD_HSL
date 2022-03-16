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
    public partial class SetParameterForm : Form
    {
        public SetParameterForm()
        {
            InitializeComponent();
            this.Load += btnRead_Click;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            txtMeasurePlcIpAddress.Text = GlobalData.MeasurePlcIpAddress;
            txtDbNumber.Text = GlobalData.DbNumber;
            txtMeasureStructLength.Text = GlobalData.MeasureStructLength;

            txtDbStartOffset.Text = GlobalData.dbStartOffset;
            txtBoolVariableNum.Text = GlobalData.boolVariableNum;
            txtIntVariableNum.Text = GlobalData.intVariableNum;
            txtRealVariableNum.Text = GlobalData.realVariableNum;
            txtDintVariableNum.Text = GlobalData.dintVariableNum;

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

        }
    }
}