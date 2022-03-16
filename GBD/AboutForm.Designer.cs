namespace GBD
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.picProductName = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProductName)).BeginInit();
            this.SuspendLayout();
            // 
            // picProductName
            // 
            this.picProductName.Image = ((System.Drawing.Image)(resources.GetObject("picProductName.Image")));
            this.picProductName.Location = new System.Drawing.Point(23, 30);
            this.picProductName.Name = "picProductName";
            this.picProductName.Size = new System.Drawing.Size(121, 140);
            this.picProductName.TabIndex = 18;
            this.picProductName.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVersion.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblVersion.Location = new System.Drawing.Point(150, 65);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(56, 16);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "版本：";
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSystemName.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblSystemName.Location = new System.Drawing.Point(197, 31);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(166, 27);
            this.lblSystemName.TabIndex = 16;
            this.lblSystemName.Text = "GBD控制系统";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueDate.Location = new System.Drawing.Point(150, 105);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(88, 16);
            this.lblIssueDate.TabIndex = 15;
            this.lblIssueDate.Text = "发布日期：";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOwner.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblOwner.Location = new System.Drawing.Point(150, 145);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(72, 16);
            this.lblOwner.TabIndex = 15;
            this.lblOwner.Text = "所属权：";
            // 
            // txtOwner
            // 
            this.txtOwner.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOwner.Location = new System.Drawing.Point(228, 139);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(221, 26);
            this.txtOwner.TabIndex = 19;
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIssueDate.Location = new System.Drawing.Point(228, 102);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(221, 26);
            this.txtIssueDate.TabIndex = 19;
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVersion.Location = new System.Drawing.Point(228, 65);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(221, 26);
            this.txtVersion.TabIndex = 19;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 231);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.picProductName);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblSystemName);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统信息";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProductName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProductName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.TextBox txtVersion;
    }
}