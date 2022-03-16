namespace GBD
{
    partial class CommunicationForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpenPLC1 = new System.Windows.Forms.Button();
            this.ClosePLC1 = new System.Windows.Forms.Button();
            this.btnReadPLC1 = new System.Windows.Forms.Button();
            this.btnWritePLC1 = new System.Windows.Forms.Button();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPingTest = new System.Windows.Forms.Button();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.btnChainTest = new System.Windows.Forms.Button();
            this.btnVeChainTest2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpenPLC1);
            this.groupBox2.Controls.Add(this.ClosePLC1);
            this.groupBox2.Controls.Add(this.btnReadPLC1);
            this.groupBox2.Controls.Add(this.btnWritePLC1);
            this.groupBox2.Controls.Add(this.textBox22);
            this.groupBox2.Location = new System.Drawing.Point(30, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 139);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLC1测试";
            // 
            // OpenPLC1
            // 
            this.OpenPLC1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.OpenPLC1.Location = new System.Drawing.Point(24, 21);
            this.OpenPLC1.Name = "OpenPLC1";
            this.OpenPLC1.Size = new System.Drawing.Size(63, 25);
            this.OpenPLC1.TabIndex = 36;
            this.OpenPLC1.Text = "打开plc1";
            this.OpenPLC1.UseVisualStyleBackColor = false;
            this.OpenPLC1.Click += new System.EventHandler(this.OpenPLC1_Click);
            // 
            // ClosePLC1
            // 
            this.ClosePLC1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClosePLC1.Location = new System.Drawing.Point(114, 22);
            this.ClosePLC1.Name = "ClosePLC1";
            this.ClosePLC1.Size = new System.Drawing.Size(63, 24);
            this.ClosePLC1.TabIndex = 37;
            this.ClosePLC1.Text = "关闭plc1";
            this.ClosePLC1.UseVisualStyleBackColor = false;
            // 
            // btnReadPLC1
            // 
            this.btnReadPLC1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReadPLC1.Location = new System.Drawing.Point(24, 52);
            this.btnReadPLC1.Name = "btnReadPLC1";
            this.btnReadPLC1.Size = new System.Drawing.Size(133, 25);
            this.btnReadPLC1.TabIndex = 38;
            this.btnReadPLC1.Text = "读取plc1数据";
            this.btnReadPLC1.UseVisualStyleBackColor = false;
            this.btnReadPLC1.Click += new System.EventHandler(this.btnReadPLC1_Click);
            // 
            // btnWritePLC1
            // 
            this.btnWritePLC1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnWritePLC1.Location = new System.Drawing.Point(85, 110);
            this.btnWritePLC1.Name = "btnWritePLC1";
            this.btnWritePLC1.Size = new System.Drawing.Size(133, 25);
            this.btnWritePLC1.TabIndex = 39;
            this.btnWritePLC1.Text = "写入plc1数据";
            this.btnWritePLC1.UseVisualStyleBackColor = false;
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox22.Location = new System.Drawing.Point(14, 110);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(58, 26);
            this.textBox22.TabIndex = 40;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRead.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead.ForeColor = System.Drawing.Color.Orange;
            this.btnRead.Location = new System.Drawing.Point(504, 360);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 50);
            this.btnRead.TabIndex = 49;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBack.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.ForeColor = System.Drawing.Color.Orange;
            this.btnBack.Location = new System.Drawing.Point(646, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPingTest
            // 
            this.btnPingTest.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPingTest.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPingTest.ForeColor = System.Drawing.Color.Orange;
            this.btnPingTest.Location = new System.Drawing.Point(204, 254);
            this.btnPingTest.Name = "btnPingTest";
            this.btnPingTest.Size = new System.Drawing.Size(115, 50);
            this.btnPingTest.TabIndex = 50;
            this.btnPingTest.Text = "Ping测试";
            this.btnPingTest.UseVisualStyleBackColor = false;
            this.btnPingTest.Click += new System.EventHandler(this.btnPingTest_Click);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIpAddress.Location = new System.Drawing.Point(30, 278);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(157, 26);
            this.txtIpAddress.TabIndex = 41;
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(33, 260);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(41, 12);
            this.lblIpAddress.TabIndex = 51;
            this.lblIpAddress.Text = "IP地址";
            // 
            // btnChainTest
            // 
            this.btnChainTest.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnChainTest.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChainTest.ForeColor = System.Drawing.Color.Orange;
            this.btnChainTest.Location = new System.Drawing.Point(530, 153);
            this.btnChainTest.Name = "btnChainTest";
            this.btnChainTest.Size = new System.Drawing.Size(206, 50);
            this.btnChainTest.TabIndex = 52;
            this.btnChainTest.Text = "VeChain API 测试";
            this.btnChainTest.UseVisualStyleBackColor = false;
            this.btnChainTest.Click += new System.EventHandler(this.btnChainTest_Click);

            // 
            // CommunicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVeChainTest2);
            this.Controls.Add(this.btnChainTest);
            this.Controls.Add(this.lblIpAddress);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.btnPingTest);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Name = "CommunicationForm";
            this.Text = "CommunicationForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OpenPLC1;
        private System.Windows.Forms.Button ClosePLC1;
        private System.Windows.Forms.Button btnReadPLC1;
        private System.Windows.Forms.Button btnWritePLC1;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPingTest;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Button btnChainTest;
        private System.Windows.Forms.Button btnVeChainTest2;
    }
}