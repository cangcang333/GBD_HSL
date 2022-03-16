namespace BWM01
{
    partial class FormulaSelectForm
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
            this.formulaSelectLabel = new System.Windows.Forms.Label();
            this.formulaSelectCombo = new System.Windows.Forms.ComboBox();
            this.lineLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.txtFormulaStatus = new System.Windows.Forms.TextBox();
            this.lblFormulaStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formulaSelectLabel
            // 
            this.formulaSelectLabel.AutoSize = true;
            this.formulaSelectLabel.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formulaSelectLabel.Location = new System.Drawing.Point(14, 76);
            this.formulaSelectLabel.Name = "formulaSelectLabel";
            this.formulaSelectLabel.Size = new System.Drawing.Size(142, 22);
            this.formulaSelectLabel.TabIndex = 0;
            this.formulaSelectLabel.Text = "配方编号选择";
            // 
            // formulaSelectCombo
            // 
            this.formulaSelectCombo.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formulaSelectCombo.FormattingEnabled = true;
            this.formulaSelectCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.formulaSelectCombo.Location = new System.Drawing.Point(16, 106);
            this.formulaSelectCombo.Name = "formulaSelectCombo";
            this.formulaSelectCombo.Size = new System.Drawing.Size(140, 29);
            this.formulaSelectCombo.TabIndex = 1;
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.lineLabel.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineLabel.Location = new System.Drawing.Point(-6, 300);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(315, 3);
            this.lineLabel.TabIndex = 3;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Location = new System.Drawing.Point(156, 359);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(122, 55);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(12, 359);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(122, 55);
            this.OK.TabIndex = 4;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // txtFormulaStatus
            // 
            this.txtFormulaStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFormulaStatus.Location = new System.Drawing.Point(12, 208);
            this.txtFormulaStatus.Multiline = true;
            this.txtFormulaStatus.Name = "txtFormulaStatus";
            this.txtFormulaStatus.Size = new System.Drawing.Size(259, 60);
            this.txtFormulaStatus.TabIndex = 5;
            // 
            // lblFormulaStatus
            // 
            this.lblFormulaStatus.AutoSize = true;
            this.lblFormulaStatus.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFormulaStatus.Location = new System.Drawing.Point(12, 178);
            this.lblFormulaStatus.Name = "lblFormulaStatus";
            this.lblFormulaStatus.Size = new System.Drawing.Size(142, 22);
            this.lblFormulaStatus.TabIndex = 6;
            this.lblFormulaStatus.Text = "配方选择状态";
            // 
            // FormulaSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(283, 457);
            this.ControlBox = false;
            this.Controls.Add(this.lblFormulaStatus);
            this.Controls.Add(this.txtFormulaStatus);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.formulaSelectCombo);
            this.Controls.Add(this.formulaSelectLabel);
            this.Name = "FormulaSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配方选择页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formulaSelectLabel;
        private System.Windows.Forms.ComboBox formulaSelectCombo;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox txtFormulaStatus;
        private System.Windows.Forms.Label lblFormulaStatus;
    }
}