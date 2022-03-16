namespace GBD
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.itemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAboutSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGBDControl = new System.Windows.Forms.Button();
            this.btnConnectMysql = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.generalTimer = new System.Windows.Forms.Timer(this.components);
            this.lblQueryInfo = new System.Windows.Forms.Label();
            this.btnReadPLC = new System.Windows.Forms.Button();
            this.btnWritePLC = new System.Windows.Forms.Button();
            this.borderRadiusPanel2 = new BWM01.BorderRadiusPanel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.txtSystemStatus = new System.Windows.Forms.TextBox();
            this.txtCurrentUser = new System.Windows.Forms.TextBox();
            this.lblSystemStatus = new System.Windows.Forms.Label();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.borderRadiusPanel1 = new BWM01.BorderRadiusPanel();
            this.btnReadFromDB = new System.Windows.Forms.Button();
            this.lblPadding2Weight = new System.Windows.Forms.Label();
            this.txtQrCodeInfo = new System.Windows.Forms.TextBox();
            this.lblPaddingWeight = new System.Windows.Forms.Label();
            this.txtQrCode1 = new System.Windows.Forms.TextBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.btnQueryBasedOnQrCode = new System.Windows.Forms.Button();
            this.lblQrCode2 = new System.Windows.Forms.Label();
            this.txtQrCode2 = new System.Windows.Forms.TextBox();
            this.mnsMainMenu.SuspendLayout();
            this.borderRadiusPanel2.SuspendLayout();
            this.borderRadiusPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMainMenu
            // 
            this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemSetting,
            this.itemAbout});
            this.mnsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMainMenu.Name = "mnsMainMenu";
            this.mnsMainMenu.Size = new System.Drawing.Size(1060, 28);
            this.mnsMainMenu.TabIndex = 0;
            this.mnsMainMenu.Text = "MainMenu";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemChangeUser,
            this.itemExit,
            this.退出ToolStripMenuItem});
            this.itemFile.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(49, 24);
            this.itemFile.Text = "文件";
            // 
            // itemChangeUser
            // 
            this.itemChangeUser.Name = "itemChangeUser";
            this.itemChangeUser.Size = new System.Drawing.Size(134, 24);
            this.itemChangeUser.Text = "切换用户";
            this.itemChangeUser.Click += new System.EventHandler(this.itemChangeUser_Click);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(134, 24);
            this.itemExit.Text = "切换配方";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // itemSetting
            // 
            this.itemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemChangePassword,
            this.itemSetParameter});
            this.itemSetting.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.itemSetting.Name = "itemSetting";
            this.itemSetting.Size = new System.Drawing.Size(49, 24);
            this.itemSetting.Text = "设置";
            // 
            // itemChangePassword
            // 
            this.itemChangePassword.Name = "itemChangePassword";
            this.itemChangePassword.Size = new System.Drawing.Size(134, 24);
            this.itemChangePassword.Text = "修改密码";
            this.itemChangePassword.Click += new System.EventHandler(this.itemChangePassword_Click);
            // 
            // itemSetParameter
            // 
            this.itemSetParameter.Name = "itemSetParameter";
            this.itemSetParameter.Size = new System.Drawing.Size(134, 24);
            this.itemSetParameter.Text = "参数设置";
            this.itemSetParameter.Click += new System.EventHandler(this.itemSetParameter_Click);
            // 
            // itemAbout
            // 
            this.itemAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAboutSystem});
            this.itemAbout.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(49, 24);
            this.itemAbout.Text = "关于";
            // 
            // itemAboutSystem
            // 
            this.itemAboutSystem.Name = "itemAboutSystem";
            this.itemAboutSystem.Size = new System.Drawing.Size(148, 24);
            this.itemAboutSystem.Text = "关于本系统";
            this.itemAboutSystem.Click += new System.EventHandler(this.itemAboutSystem_Click);
            // 
            // btnGBDControl
            // 
            this.btnGBDControl.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGBDControl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGBDControl.Location = new System.Drawing.Point(755, 547);
            this.btnGBDControl.Name = "btnGBDControl";
            this.btnGBDControl.Size = new System.Drawing.Size(124, 56);
            this.btnGBDControl.TabIndex = 1;
            this.btnGBDControl.Text = "数据导出";
            this.btnGBDControl.UseVisualStyleBackColor = false;
            this.btnGBDControl.Click += new System.EventHandler(this.btnGBDControl_Click);
            // 
            // btnConnectMysql
            // 
            this.btnConnectMysql.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnConnectMysql.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnectMysql.Location = new System.Drawing.Point(597, 548);
            this.btnConnectMysql.Name = "btnConnectMysql";
            this.btnConnectMysql.Size = new System.Drawing.Size(124, 56);
            this.btnConnectMysql.TabIndex = 1;
            this.btnConnectMysql.Text = "Insert MySQL";
            this.btnConnectMysql.UseVisualStyleBackColor = false;
            this.btnConnectMysql.Click += new System.EventHandler(this.btnConnectMysql_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(913, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(215, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 27);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "特斯拉IGBT控制系统";
            // 
            // generalTimer
            // 
            this.generalTimer.Interval = 1000;
            this.generalTimer.Tick += new System.EventHandler(this.generalTimer_Tick);
            // 
            // lblQueryInfo
            // 
            this.lblQueryInfo.AutoSize = true;
            this.lblQueryInfo.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQueryInfo.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblQueryInfo.Location = new System.Drawing.Point(12, 127);
            this.lblQueryInfo.Name = "lblQueryInfo";
            this.lblQueryInfo.Size = new System.Drawing.Size(72, 16);
            this.lblQueryInfo.TabIndex = 50;
            this.lblQueryInfo.Text = "信息查询";
            // 
            // btnReadPLC
            // 
            this.btnReadPLC.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReadPLC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadPLC.Location = new System.Drawing.Point(307, 551);
            this.btnReadPLC.Name = "btnReadPLC";
            this.btnReadPLC.Size = new System.Drawing.Size(111, 53);
            this.btnReadPLC.TabIndex = 71;
            this.btnReadPLC.Text = "读取PLC数据";
            this.btnReadPLC.UseVisualStyleBackColor = false;
            this.btnReadPLC.Click += new System.EventHandler(this.btnReadPLC_Click);
            // 
            // btnWritePLC
            // 
            this.btnWritePLC.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnWritePLC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWritePLC.Location = new System.Drawing.Point(452, 550);
            this.btnWritePLC.Name = "btnWritePLC";
            this.btnWritePLC.Size = new System.Drawing.Size(111, 53);
            this.btnWritePLC.TabIndex = 72;
            this.btnWritePLC.Text = "写入PLC数据";
            this.btnWritePLC.UseVisualStyleBackColor = false;
            this.btnWritePLC.Click += new System.EventHandler(this.btnWritePLC_Click);
            // 
            // borderRadiusPanel2
            // 
            this.borderRadiusPanel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.borderRadiusPanel2.Controls.Add(this.lblCurrentUser);
            this.borderRadiusPanel2.Controls.Add(this.txtSystemStatus);
            this.borderRadiusPanel2.Controls.Add(this.txtCurrentUser);
            this.borderRadiusPanel2.Controls.Add(this.lblSystemStatus);
            this.borderRadiusPanel2.Controls.Add(this.txtCurrentTime);
            this.borderRadiusPanel2.Controls.Add(this.lblCurrentTime);
            this.borderRadiusPanel2.Location = new System.Drawing.Point(13, 53);
            this.borderRadiusPanel2.Name = "borderRadiusPanel2";
            this.borderRadiusPanel2.Size = new System.Drawing.Size(865, 40);
            this.borderRadiusPanel2.TabIndex = 51;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblCurrentUser.Location = new System.Drawing.Point(561, 12);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(72, 16);
            this.lblCurrentUser.TabIndex = 45;
            this.lblCurrentUser.Text = "当前用户";
            // 
            // txtSystemStatus
            // 
            this.txtSystemStatus.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSystemStatus.Location = new System.Drawing.Point(100, 6);
            this.txtSystemStatus.Name = "txtSystemStatus";
            this.txtSystemStatus.Size = new System.Drawing.Size(204, 26);
            this.txtSystemStatus.TabIndex = 43;
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCurrentUser.Location = new System.Drawing.Point(645, 3);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.Size = new System.Drawing.Size(101, 26);
            this.txtCurrentUser.TabIndex = 21;
            // 
            // lblSystemStatus
            // 
            this.lblSystemStatus.AutoSize = true;
            this.lblSystemStatus.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSystemStatus.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblSystemStatus.Location = new System.Drawing.Point(22, 9);
            this.lblSystemStatus.Name = "lblSystemStatus";
            this.lblSystemStatus.Size = new System.Drawing.Size(72, 16);
            this.lblSystemStatus.TabIndex = 42;
            this.lblSystemStatus.Text = "系统状态";
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCurrentTime.Location = new System.Drawing.Point(1398, 5);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.Size = new System.Drawing.Size(182, 26);
            this.txtCurrentTime.TabIndex = 21;
            this.txtCurrentTime.Text = " ";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblCurrentTime.Location = new System.Drawing.Point(1290, 9);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(104, 16);
            this.lblCurrentTime.TabIndex = 20;
            this.lblCurrentTime.Text = "当前系统时间";
            // 
            // borderRadiusPanel1
            // 
            this.borderRadiusPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.borderRadiusPanel1.Controls.Add(this.lblQrCode2);
            this.borderRadiusPanel1.Controls.Add(this.txtQrCode2);
            this.borderRadiusPanel1.Controls.Add(this.btnQueryBasedOnQrCode);
            this.borderRadiusPanel1.Controls.Add(this.rbFail);
            this.borderRadiusPanel1.Controls.Add(this.rbPass);
            this.borderRadiusPanel1.Controls.Add(this.rbAll);
            this.borderRadiusPanel1.Controls.Add(this.btnReadFromDB);
            this.borderRadiusPanel1.Controls.Add(this.lblPadding2Weight);
            this.borderRadiusPanel1.Controls.Add(this.txtQrCodeInfo);
            this.borderRadiusPanel1.Controls.Add(this.lblPaddingWeight);
            this.borderRadiusPanel1.Controls.Add(this.txtQrCode1);
            this.borderRadiusPanel1.Location = new System.Drawing.Point(9, 146);
            this.borderRadiusPanel1.Name = "borderRadiusPanel1";
            this.borderRadiusPanel1.Size = new System.Drawing.Size(1017, 395);
            this.borderRadiusPanel1.TabIndex = 49;
            // 
            // btnReadFromDB
            // 
            this.btnReadFromDB.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReadFromDB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadFromDB.Location = new System.Drawing.Point(253, 9);
            this.btnReadFromDB.Name = "btnReadFromDB";
            this.btnReadFromDB.Size = new System.Drawing.Size(180, 43);
            this.btnReadFromDB.TabIndex = 73;
            this.btnReadFromDB.Text = "最新条码信息查询";
            this.btnReadFromDB.UseVisualStyleBackColor = false;
            this.btnReadFromDB.Click += new System.EventHandler(this.btnReadFromDB_Click);
            // 
            // lblPadding2Weight
            // 
            this.lblPadding2Weight.AutoSize = true;
            this.lblPadding2Weight.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPadding2Weight.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblPadding2Weight.Location = new System.Drawing.Point(52, 9);
            this.lblPadding2Weight.Name = "lblPadding2Weight";
            this.lblPadding2Weight.Size = new System.Drawing.Size(184, 16);
            this.lblPadding2Weight.TabIndex = 62;
            this.lblPadding2Weight.Text = "Query Filter Condition";
            // 
            // txtQrCodeInfo
            // 
            this.txtQrCodeInfo.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQrCodeInfo.Location = new System.Drawing.Point(13, 62);
            this.txtQrCodeInfo.Multiline = true;
            this.txtQrCodeInfo.Name = "txtQrCodeInfo";
            this.txtQrCodeInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQrCodeInfo.Size = new System.Drawing.Size(786, 321);
            this.txtQrCodeInfo.TabIndex = 60;
            this.txtQrCodeInfo.Text = " ";
            // 
            // lblPaddingWeight
            // 
            this.lblPaddingWeight.AutoSize = true;
            this.lblPaddingWeight.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPaddingWeight.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblPaddingWeight.Location = new System.Drawing.Point(805, 50);
            this.lblPaddingWeight.Name = "lblPaddingWeight";
            this.lblPaddingWeight.Size = new System.Drawing.Size(112, 16);
            this.lblPaddingWeight.TabIndex = 20;
            this.lblPaddingWeight.Text = "给定条码1信息";
            // 
            // txtQrCode1
            // 
            this.txtQrCode1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQrCode1.Location = new System.Drawing.Point(808, 69);
            this.txtQrCode1.Name = "txtQrCode1";
            this.txtQrCode1.Size = new System.Drawing.Size(180, 26);
            this.txtQrCode1.TabIndex = 21;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(66, 34);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(41, 16);
            this.rbAll.TabIndex = 74;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Location = new System.Drawing.Point(115, 34);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(59, 16);
            this.rbPass.TabIndex = 74;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Passed";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Location = new System.Drawing.Point(176, 34);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(59, 16);
            this.rbFail.TabIndex = 75;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Failed";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // btnQueryBasedOnQrCode
            // 
            this.btnQueryBasedOnQrCode.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnQueryBasedOnQrCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryBasedOnQrCode.Location = new System.Drawing.Point(808, 166);
            this.btnQueryBasedOnQrCode.Name = "btnQueryBasedOnQrCode";
            this.btnQueryBasedOnQrCode.Size = new System.Drawing.Size(180, 43);
            this.btnQueryBasedOnQrCode.TabIndex = 76;
            this.btnQueryBasedOnQrCode.Text = "给定条码信息查询";
            this.btnQueryBasedOnQrCode.UseVisualStyleBackColor = false;
            this.btnQueryBasedOnQrCode.Click += new System.EventHandler(this.btnQueryBasedOnQrCode_Click);
            // 
            // lblQrCode2
            // 
            this.lblQrCode2.AutoSize = true;
            this.lblQrCode2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQrCode2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblQrCode2.Location = new System.Drawing.Point(805, 111);
            this.lblQrCode2.Name = "lblQrCode2";
            this.lblQrCode2.Size = new System.Drawing.Size(112, 16);
            this.lblQrCode2.TabIndex = 77;
            this.lblQrCode2.Text = "给定条码2信息";
            // 
            // txtQrCode2
            // 
            this.txtQrCode2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQrCode2.Location = new System.Drawing.Point(808, 130);
            this.txtQrCode2.Name = "txtQrCode2";
            this.txtQrCode2.Size = new System.Drawing.Size(180, 26);
            this.txtQrCode2.TabIndex = 78;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1060, 611);
            this.ControlBox = false;
            this.Controls.Add(this.btnWritePLC);
            this.Controls.Add(this.btnReadPLC);
            this.Controls.Add(this.borderRadiusPanel2);
            this.Controls.Add(this.lblQueryInfo);
            this.Controls.Add(this.borderRadiusPanel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnectMysql);
            this.Controls.Add(this.btnGBDControl);
            this.Controls.Add(this.mnsMainMenu);
            this.MainMenuStrip = this.mnsMainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GBD控制系统";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            this.borderRadiusPanel2.ResumeLayout(false);
            this.borderRadiusPanel2.PerformLayout();
            this.borderRadiusPanel1.ResumeLayout(false);
            this.borderRadiusPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemChangeUser;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem itemSetting;
        private System.Windows.Forms.ToolStripMenuItem itemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem itemSetParameter;
        private System.Windows.Forms.ToolStripMenuItem itemAbout;
        private System.Windows.Forms.ToolStripMenuItem itemAboutSystem;
        private System.Windows.Forms.Button btnGBDControl;
        private System.Windows.Forms.Button btnConnectMysql;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.Label lblPaddingWeight;
        private System.Windows.Forms.TextBox txtQrCode1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCurrentUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSystemStatus;
        private System.Windows.Forms.Label lblSystemStatus;
        private System.Windows.Forms.Timer generalTimer;
        private BWM01.BorderRadiusPanel borderRadiusPanel1;
        private System.Windows.Forms.Label lblQueryInfo;
        private BWM01.BorderRadiusPanel borderRadiusPanel2;
        private System.Windows.Forms.TextBox txtQrCodeInfo;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label lblPadding2Weight;
        private System.Windows.Forms.Button btnReadPLC;
        private System.Windows.Forms.Button btnWritePLC;
        private System.Windows.Forms.Button btnReadFromDB;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnQueryBasedOnQrCode;
        private System.Windows.Forms.Label lblQrCode2;
        private System.Windows.Forms.TextBox txtQrCode2;
    }
}