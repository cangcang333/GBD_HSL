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
            this.txtQueryResultInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQrCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode2FinalResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode1FinalResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode2CheckResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode1CheckResult = new System.Windows.Forms.TextBox();
            this.lblQrCode2 = new System.Windows.Forms.Label();
            this.txtQrCode2 = new System.Windows.Forms.TextBox();
            this.btnQueryBasedOnQrCode = new System.Windows.Forms.Button();
            this.lblPadding2Weight = new System.Windows.Forms.Label();
            this.txtQrCodeInfo = new System.Windows.Forms.TextBox();
            this.lblPaddingWeight = new System.Windows.Forms.Label();
            this.txtQrCode1 = new System.Windows.Forms.TextBox();
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
            this.mnsMainMenu.Size = new System.Drawing.Size(1109, 28);
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
            this.btnGBDControl.Location = new System.Drawing.Point(755, 604);
            this.btnGBDControl.Name = "btnGBDControl";
            this.btnGBDControl.Size = new System.Drawing.Size(124, 56);
            this.btnGBDControl.TabIndex = 1;
            this.btnGBDControl.Text = "数据导出";
            this.btnGBDControl.UseVisualStyleBackColor = false;
            this.btnGBDControl.Click += new System.EventHandler(this.btnGBDControl_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(913, 604);
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
            this.lblQueryInfo.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQueryInfo.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblQueryInfo.Location = new System.Drawing.Point(12, 120);
            this.lblQueryInfo.Name = "lblQueryInfo";
            this.lblQueryInfo.Size = new System.Drawing.Size(98, 21);
            this.lblQueryInfo.TabIndex = 50;
            this.lblQueryInfo.Text = "运行信息";
            // 
            // btnReadPLC
            // 
            this.btnReadPLC.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReadPLC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadPLC.Location = new System.Drawing.Point(462, 609);
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
            this.btnWritePLC.Location = new System.Drawing.Point(606, 607);
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
            this.borderRadiusPanel1.Controls.Add(this.txtQueryResultInfo);
            this.borderRadiusPanel1.Controls.Add(this.label6);
            this.borderRadiusPanel1.Controls.Add(this.txtQrCode);
            this.borderRadiusPanel1.Controls.Add(this.label5);
            this.borderRadiusPanel1.Controls.Add(this.label3);
            this.borderRadiusPanel1.Controls.Add(this.txtCode2FinalResult);
            this.borderRadiusPanel1.Controls.Add(this.label4);
            this.borderRadiusPanel1.Controls.Add(this.txtCode1FinalResult);
            this.borderRadiusPanel1.Controls.Add(this.label1);
            this.borderRadiusPanel1.Controls.Add(this.txtCode2CheckResult);
            this.borderRadiusPanel1.Controls.Add(this.label2);
            this.borderRadiusPanel1.Controls.Add(this.txtCode1CheckResult);
            this.borderRadiusPanel1.Controls.Add(this.lblQrCode2);
            this.borderRadiusPanel1.Controls.Add(this.txtQrCode2);
            this.borderRadiusPanel1.Controls.Add(this.btnQueryBasedOnQrCode);
            this.borderRadiusPanel1.Controls.Add(this.lblPadding2Weight);
            this.borderRadiusPanel1.Controls.Add(this.txtQrCodeInfo);
            this.borderRadiusPanel1.Controls.Add(this.lblPaddingWeight);
            this.borderRadiusPanel1.Controls.Add(this.txtQrCode1);
            this.borderRadiusPanel1.Location = new System.Drawing.Point(9, 146);
            this.borderRadiusPanel1.Name = "borderRadiusPanel1";
            this.borderRadiusPanel1.Size = new System.Drawing.Size(1086, 452);
            this.borderRadiusPanel1.TabIndex = 49;
            // 
            // txtQueryResultInfo
            // 
            this.txtQueryResultInfo.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQueryResultInfo.Location = new System.Drawing.Point(13, 356);
            this.txtQueryResultInfo.Multiline = true;
            this.txtQueryResultInfo.Name = "txtQueryResultInfo";
            this.txtQueryResultInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQueryResultInfo.Size = new System.Drawing.Size(1049, 80);
            this.txtQueryResultInfo.TabIndex = 93;
            this.txtQueryResultInfo.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Location = new System.Drawing.Point(30, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 89;
            this.label6.Text = "条码值";
            // 
            // txtQrCode
            // 
            this.txtQrCode.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQrCode.Location = new System.Drawing.Point(111, 316);
            this.txtQrCode.Name = "txtQrCode";
            this.txtQrCode.Size = new System.Drawing.Size(315, 26);
            this.txtQrCode.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "历史工件检测信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(797, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "条码2结果";
            // 
            // txtCode2FinalResult
            // 
            this.txtCode2FinalResult.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode2FinalResult.Location = new System.Drawing.Point(892, 71);
            this.txtCode2FinalResult.Name = "txtCode2FinalResult";
            this.txtCode2FinalResult.Size = new System.Drawing.Size(100, 26);
            this.txtCode2FinalResult.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(797, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 83;
            this.label4.Text = "条码1结果";
            // 
            // txtCode1FinalResult
            // 
            this.txtCode1FinalResult.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode1FinalResult.Location = new System.Drawing.Point(892, 39);
            this.txtCode1FinalResult.Name = "txtCode1FinalResult";
            this.txtCode1FinalResult.Size = new System.Drawing.Size(100, 26);
            this.txtCode1FinalResult.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(335, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "条码2检测值";
            // 
            // txtCode2CheckResult
            // 
            this.txtCode2CheckResult.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode2CheckResult.Location = new System.Drawing.Point(453, 71);
            this.txtCode2CheckResult.Name = "txtCode2CheckResult";
            this.txtCode2CheckResult.Size = new System.Drawing.Size(315, 26);
            this.txtCode2CheckResult.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(335, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "条码1检测值";
            // 
            // txtCode1CheckResult
            // 
            this.txtCode1CheckResult.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode1CheckResult.Location = new System.Drawing.Point(453, 39);
            this.txtCode1CheckResult.Name = "txtCode1CheckResult";
            this.txtCode1CheckResult.Size = new System.Drawing.Size(315, 26);
            this.txtCode1CheckResult.TabIndex = 80;
            // 
            // lblQrCode2
            // 
            this.lblQrCode2.AutoSize = true;
            this.lblQrCode2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQrCode2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblQrCode2.Location = new System.Drawing.Point(10, 79);
            this.lblQrCode2.Name = "lblQrCode2";
            this.lblQrCode2.Size = new System.Drawing.Size(112, 16);
            this.lblQrCode2.TabIndex = 77;
            this.lblQrCode2.Text = "当前条码2信息";
            // 
            // txtQrCode2
            // 
            this.txtQrCode2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQrCode2.Location = new System.Drawing.Point(128, 71);
            this.txtQrCode2.Name = "txtQrCode2";
            this.txtQrCode2.Size = new System.Drawing.Size(180, 26);
            this.txtQrCode2.TabIndex = 78;
            // 
            // btnQueryBasedOnQrCode
            // 
            this.btnQueryBasedOnQrCode.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnQueryBasedOnQrCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryBasedOnQrCode.Location = new System.Drawing.Point(482, 307);
            this.btnQueryBasedOnQrCode.Name = "btnQueryBasedOnQrCode";
            this.btnQueryBasedOnQrCode.Size = new System.Drawing.Size(88, 43);
            this.btnQueryBasedOnQrCode.TabIndex = 76;
            this.btnQueryBasedOnQrCode.Text = "给定条码信息查询";
            this.btnQueryBasedOnQrCode.UseVisualStyleBackColor = false;
            this.btnQueryBasedOnQrCode.Click += new System.EventHandler(this.btnQueryBasedOnQrCode_Click);
            // 
            // lblPadding2Weight
            // 
            this.lblPadding2Weight.AutoSize = true;
            this.lblPadding2Weight.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPadding2Weight.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblPadding2Weight.Location = new System.Drawing.Point(8, 9);
            this.lblPadding2Weight.Name = "lblPadding2Weight";
            this.lblPadding2Weight.Size = new System.Drawing.Size(72, 16);
            this.lblPadding2Weight.TabIndex = 62;
            this.lblPadding2Weight.Text = "实时信息";
            // 
            // txtQrCodeInfo
            // 
            this.txtQrCodeInfo.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQrCodeInfo.Location = new System.Drawing.Point(11, 149);
            this.txtQrCodeInfo.MaxLength = 32767000;
            this.txtQrCodeInfo.Multiline = true;
            this.txtQrCodeInfo.Name = "txtQrCodeInfo";
            this.txtQrCodeInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQrCodeInfo.Size = new System.Drawing.Size(1049, 134);
            this.txtQrCodeInfo.TabIndex = 60;
            this.txtQrCodeInfo.Text = " ";
            // 
            // lblPaddingWeight
            // 
            this.lblPaddingWeight.AutoSize = true;
            this.lblPaddingWeight.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPaddingWeight.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblPaddingWeight.Location = new System.Drawing.Point(10, 42);
            this.lblPaddingWeight.Name = "lblPaddingWeight";
            this.lblPaddingWeight.Size = new System.Drawing.Size(112, 16);
            this.lblPaddingWeight.TabIndex = 20;
            this.lblPaddingWeight.Text = "当前条码1信息";
            // 
            // txtQrCode1
            // 
            this.txtQrCode1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQrCode1.Location = new System.Drawing.Point(128, 39);
            this.txtQrCode1.Name = "txtQrCode1";
            this.txtQrCode1.Size = new System.Drawing.Size(180, 26);
            this.txtQrCode1.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1109, 674);
            this.ControlBox = false;
            this.Controls.Add(this.btnWritePLC);
            this.Controls.Add(this.btnReadPLC);
            this.Controls.Add(this.borderRadiusPanel2);
            this.Controls.Add(this.lblQueryInfo);
            this.Controls.Add(this.borderRadiusPanel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
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
        private System.Windows.Forms.Button btnQueryBasedOnQrCode;
        private System.Windows.Forms.Label lblQrCode2;
        private System.Windows.Forms.TextBox txtQrCode2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode2FinalResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode1FinalResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode2CheckResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode1CheckResult;
        private System.Windows.Forms.TextBox txtQueryResultInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQrCode;
    }
}