namespace GBD
{
    partial class SetParameterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRealVariableNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblMeasurePlcIpAddress = new System.Windows.Forms.Label();
            this.txtMeasurePlcIpAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDbNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDbStartOffset = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoolVariableNum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIntVariableNum = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDintVariableNum = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtMeasureLaserIp = new System.Windows.Forms.TextBox();
            this.lblMeasureLaserIp = new System.Windows.Forms.Label();
            this.txtRecheckLaserIp = new System.Windows.Forms.TextBox();
            this.lblRecheckLaserIp = new System.Windows.Forms.Label();
            this.txtShrinkagePlcIpAddress = new System.Windows.Forms.TextBox();
            this.lblShrinkagePlcIpAddress = new System.Windows.Forms.Label();
            this.txtMeasureStructLength = new System.Windows.Forms.TextBox();
            this.lblMeasureStructLength = new System.Windows.Forms.Label();
            this.txtWeightDbNum = new System.Windows.Forms.TextBox();
            this.lblWeightDbNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRealVariableNum
            // 
            this.txtRealVariableNum.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRealVariableNum.Location = new System.Drawing.Point(402, 254);
            this.txtRealVariableNum.Name = "txtRealVariableNum";
            this.txtRealVariableNum.Size = new System.Drawing.Size(87, 26);
            this.txtRealVariableNum.TabIndex = 33;
            this.txtRealVariableNum.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(292, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "REAL变量个数";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Orange;
            this.btnCancel.Location = new System.Drawing.Point(258, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "返回";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRead.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead.ForeColor = System.Drawing.Color.Orange;
            this.btnRead.Location = new System.Drawing.Point(116, 530);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 50);
            this.btnRead.TabIndex = 47;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblMeasurePlcIpAddress
            // 
            this.lblMeasurePlcIpAddress.AutoSize = true;
            this.lblMeasurePlcIpAddress.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMeasurePlcIpAddress.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMeasurePlcIpAddress.Location = new System.Drawing.Point(329, 25);
            this.lblMeasurePlcIpAddress.Name = "lblMeasurePlcIpAddress";
            this.lblMeasurePlcIpAddress.Size = new System.Drawing.Size(120, 16);
            this.lblMeasurePlcIpAddress.TabIndex = 39;
            this.lblMeasurePlcIpAddress.Text = "测径PLC IP地址";
            // 
            // txtMeasurePlcIpAddress
            // 
            this.txtMeasurePlcIpAddress.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMeasurePlcIpAddress.Location = new System.Drawing.Point(455, 22);
            this.txtMeasurePlcIpAddress.Name = "txtMeasurePlcIpAddress";
            this.txtMeasurePlcIpAddress.Size = new System.Drawing.Size(156, 26);
            this.txtMeasurePlcIpAddress.TabIndex = 45;
            this.txtMeasurePlcIpAddress.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.DarkOrange;
            this.label14.Location = new System.Drawing.Point(19, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "测径DB块编号及起始地址";
            // 
            // txtDbNumber
            // 
            this.txtDbNumber.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDbNumber.Location = new System.Drawing.Point(209, 39);
            this.txtDbNumber.Name = "txtDbNumber";
            this.txtDbNumber.Size = new System.Drawing.Size(87, 26);
            this.txtDbNumber.TabIndex = 44;
            this.txtDbNumber.Text = " ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(19, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "缩径DB块";
            // 
            // txtDbStartOffset
            // 
            this.txtDbStartOffset.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDbStartOffset.Location = new System.Drawing.Point(129, 118);
            this.txtDbStartOffset.Name = "txtDbStartOffset";
            this.txtDbStartOffset.Size = new System.Drawing.Size(87, 26);
            this.txtDbStartOffset.TabIndex = 43;
            this.txtDbStartOffset.Text = " ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.DarkOrange;
            this.label16.Location = new System.Drawing.Point(19, 256);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 16);
            this.label16.TabIndex = 36;
            this.label16.Text = "BOOL变量个数";
            // 
            // txtBoolVariableNum
            // 
            this.txtBoolVariableNum.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoolVariableNum.Location = new System.Drawing.Point(129, 253);
            this.txtBoolVariableNum.Name = "txtBoolVariableNum";
            this.txtBoolVariableNum.Size = new System.Drawing.Size(87, 26);
            this.txtBoolVariableNum.TabIndex = 42;
            this.txtBoolVariableNum.Text = " ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.DarkOrange;
            this.label17.Location = new System.Drawing.Point(19, 300);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "INT变量个数";
            // 
            // txtIntVariableNum
            // 
            this.txtIntVariableNum.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIntVariableNum.Location = new System.Drawing.Point(129, 297);
            this.txtIntVariableNum.Name = "txtIntVariableNum";
            this.txtIntVariableNum.Size = new System.Drawing.Size(87, 26);
            this.txtIntVariableNum.TabIndex = 41;
            this.txtIntVariableNum.Text = " ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.DarkOrange;
            this.label18.Location = new System.Drawing.Point(292, 300);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 16);
            this.label18.TabIndex = 34;
            this.label18.Text = "DINT变量个数";
            // 
            // txtDintVariableNum
            // 
            this.txtDintVariableNum.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDintVariableNum.Location = new System.Drawing.Point(402, 297);
            this.txtDintVariableNum.Name = "txtDintVariableNum";
            this.txtDintVariableNum.Size = new System.Drawing.Size(87, 26);
            this.txtDintVariableNum.TabIndex = 40;
            this.txtDintVariableNum.Text = " ";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnWrite.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWrite.ForeColor = System.Drawing.Color.Orange;
            this.btnWrite.Location = new System.Drawing.Point(10, 530);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(100, 50);
            this.btnWrite.TabIndex = 48;
            this.btnWrite.Text = "写入";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtMeasureLaserIp
            // 
            this.txtMeasureLaserIp.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMeasureLaserIp.Location = new System.Drawing.Point(129, 353);
            this.txtMeasureLaserIp.Name = "txtMeasureLaserIp";
            this.txtMeasureLaserIp.Size = new System.Drawing.Size(156, 26);
            this.txtMeasureLaserIp.TabIndex = 50;
            this.txtMeasureLaserIp.Text = " ";
            // 
            // lblMeasureLaserIp
            // 
            this.lblMeasureLaserIp.AutoSize = true;
            this.lblMeasureLaserIp.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMeasureLaserIp.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMeasureLaserIp.Location = new System.Drawing.Point(7, 358);
            this.lblMeasureLaserIp.Name = "lblMeasureLaserIp";
            this.lblMeasureLaserIp.Size = new System.Drawing.Size(120, 16);
            this.lblMeasureLaserIp.TabIndex = 49;
            this.lblMeasureLaserIp.Text = "测径激光IP地址";
            // 
            // txtRecheckLaserIp
            // 
            this.txtRecheckLaserIp.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecheckLaserIp.Location = new System.Drawing.Point(129, 395);
            this.txtRecheckLaserIp.Name = "txtRecheckLaserIp";
            this.txtRecheckLaserIp.Size = new System.Drawing.Size(156, 26);
            this.txtRecheckLaserIp.TabIndex = 52;
            this.txtRecheckLaserIp.Text = " ";
            // 
            // lblRecheckLaserIp
            // 
            this.lblRecheckLaserIp.AutoSize = true;
            this.lblRecheckLaserIp.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecheckLaserIp.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRecheckLaserIp.Location = new System.Drawing.Point(7, 400);
            this.lblRecheckLaserIp.Name = "lblRecheckLaserIp";
            this.lblRecheckLaserIp.Size = new System.Drawing.Size(120, 16);
            this.lblRecheckLaserIp.TabIndex = 51;
            this.lblRecheckLaserIp.Text = "复测激光IP地址";
            // 
            // txtShrinkagePlcIpAddress
            // 
            this.txtShrinkagePlcIpAddress.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShrinkagePlcIpAddress.Location = new System.Drawing.Point(455, 68);
            this.txtShrinkagePlcIpAddress.Name = "txtShrinkagePlcIpAddress";
            this.txtShrinkagePlcIpAddress.Size = new System.Drawing.Size(156, 26);
            this.txtShrinkagePlcIpAddress.TabIndex = 55;
            this.txtShrinkagePlcIpAddress.Text = " ";
            // 
            // lblShrinkagePlcIpAddress
            // 
            this.lblShrinkagePlcIpAddress.AutoSize = true;
            this.lblShrinkagePlcIpAddress.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShrinkagePlcIpAddress.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblShrinkagePlcIpAddress.Location = new System.Drawing.Point(329, 71);
            this.lblShrinkagePlcIpAddress.Name = "lblShrinkagePlcIpAddress";
            this.lblShrinkagePlcIpAddress.Size = new System.Drawing.Size(120, 16);
            this.lblShrinkagePlcIpAddress.TabIndex = 54;
            this.lblShrinkagePlcIpAddress.Text = "缩径PLC IP地址";
            // 
            // txtMeasureStructLength
            // 
            this.txtMeasureStructLength.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMeasureStructLength.Location = new System.Drawing.Point(209, 76);
            this.txtMeasureStructLength.Name = "txtMeasureStructLength";
            this.txtMeasureStructLength.Size = new System.Drawing.Size(87, 26);
            this.txtMeasureStructLength.TabIndex = 60;
            this.txtMeasureStructLength.Text = " ";
            // 
            // lblMeasureStructLength
            // 
            this.lblMeasureStructLength.AutoSize = true;
            this.lblMeasureStructLength.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMeasureStructLength.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMeasureStructLength.Location = new System.Drawing.Point(19, 79);
            this.lblMeasureStructLength.Name = "lblMeasureStructLength";
            this.lblMeasureStructLength.Size = new System.Drawing.Size(120, 16);
            this.lblMeasureStructLength.TabIndex = 59;
            this.lblMeasureStructLength.Text = "测径结构体长度";
            // 
            // txtWeightDbNum
            // 
            this.txtWeightDbNum.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWeightDbNum.Location = new System.Drawing.Point(129, 161);
            this.txtWeightDbNum.Name = "txtWeightDbNum";
            this.txtWeightDbNum.Size = new System.Drawing.Size(87, 26);
            this.txtWeightDbNum.TabIndex = 62;
            this.txtWeightDbNum.Text = " ";
            // 
            // lblWeightDbNum
            // 
            this.lblWeightDbNum.AutoSize = true;
            this.lblWeightDbNum.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWeightDbNum.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblWeightDbNum.Location = new System.Drawing.Point(19, 164);
            this.lblWeightDbNum.Name = "lblWeightDbNum";
            this.lblWeightDbNum.Size = new System.Drawing.Size(72, 16);
            this.lblWeightDbNum.TabIndex = 61;
            this.lblWeightDbNum.Text = "称重DB块";
            // 
            // SetParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 703);
            this.Controls.Add(this.txtWeightDbNum);
            this.Controls.Add(this.lblWeightDbNum);
            this.Controls.Add(this.txtMeasureStructLength);
            this.Controls.Add(this.lblMeasureStructLength);
            this.Controls.Add(this.txtShrinkagePlcIpAddress);
            this.Controls.Add(this.lblShrinkagePlcIpAddress);
            this.Controls.Add(this.txtRecheckLaserIp);
            this.Controls.Add(this.lblRecheckLaserIp);
            this.Controls.Add(this.txtMeasureLaserIp);
            this.Controls.Add(this.lblMeasureLaserIp);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDintVariableNum);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtIntVariableNum);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBoolVariableNum);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDbStartOffset);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDbNumber);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMeasurePlcIpAddress);
            this.Controls.Add(this.lblMeasurePlcIpAddress);
            this.Controls.Add(this.txtRealVariableNum);
            this.Controls.Add(this.label4);
            this.Name = "SetParameterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数设置页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRealVariableNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblMeasurePlcIpAddress;
        private System.Windows.Forms.TextBox txtMeasurePlcIpAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDbNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDbStartOffset;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoolVariableNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIntVariableNum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDintVariableNum;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtMeasureLaserIp;
        private System.Windows.Forms.Label lblMeasureLaserIp;
        private System.Windows.Forms.TextBox txtRecheckLaserIp;
        private System.Windows.Forms.Label lblRecheckLaserIp;
        private System.Windows.Forms.TextBox txtShrinkagePlcIpAddress;
        private System.Windows.Forms.Label lblShrinkagePlcIpAddress;
        private System.Windows.Forms.TextBox txtMeasureStructLength;
        private System.Windows.Forms.Label lblMeasureStructLength;
        private System.Windows.Forms.TextBox txtWeightDbNum;
        private System.Windows.Forms.Label lblWeightDbNum;
    }
}