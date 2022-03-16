namespace GBD
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picUserLogin = new System.Windows.Forms.PictureBox();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.picProductName = new System.Windows.Forms.PictureBox();
            this.userTypeCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(447, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(340, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 38);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(402, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(135, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblUserName.Location = new System.Drawing.Point(323, 90);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(72, 16);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "用户名：";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPassword.Location = new System.Drawing.Point(323, 127);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 16);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "密码：";
            // 
            // picUserLogin
            // 
            this.picUserLogin.Image = ((System.Drawing.Image)(resources.GetObject("picUserLogin.Image")));
            this.picUserLogin.Location = new System.Drawing.Point(326, 23);
            this.picUserLogin.Name = "picUserLogin";
            this.picUserLogin.Size = new System.Drawing.Size(66, 64);
            this.picUserLogin.TabIndex = 11;
            this.picUserLogin.TabStop = false;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblUserLogin.Location = new System.Drawing.Point(395, 44);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(142, 22);
            this.lblUserLogin.TabIndex = 12;
            this.lblUserLogin.Text = "系统用户登录";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProductName.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtProductName.Location = new System.Drawing.Point(150, 108);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(117, 58);
            this.txtProductName.TabIndex = 13;
            this.txtProductName.Text = "G B D 控制系统";
            // 
            // picProductName
            // 
            this.picProductName.Image = ((System.Drawing.Image)(resources.GetObject("picProductName.Image")));
            this.picProductName.Location = new System.Drawing.Point(28, 37);
            this.picProductName.Name = "picProductName";
            this.picProductName.Size = new System.Drawing.Size(121, 140);
            this.picProductName.TabIndex = 14;
            this.picProductName.TabStop = false;
            // 
            // userTypeCombo
            // 
            this.userTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeCombo.FormattingEnabled = true;
            this.userTypeCombo.Items.AddRange(new object[] {
            "操作员",
            "工程师"});
            this.userTypeCombo.Location = new System.Drawing.Point(402, 90);
            this.userTypeCombo.Name = "userTypeCombo";
            this.userTypeCombo.Size = new System.Drawing.Size(121, 20);
            this.userTypeCombo.TabIndex = 15;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 257);
            this.Controls.Add(this.userTypeCombo);
            this.Controls.Add(this.picProductName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.picUserLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录页面";
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picUserLogin;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.PictureBox picProductName;
        private System.Windows.Forms.ComboBox userTypeCombo;
    }
}

