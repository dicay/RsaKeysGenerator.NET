namespace RsaGenerateKey.NET
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblKeySize = new System.Windows.Forms.Label();
            this.txtKeySize = new System.Windows.Forms.TextBox();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkXmlFormat = new System.Windows.Forms.CheckBox();
            this.chkPemFormat = new System.Windows.Forms.CheckBox();
            this.chkDerFormat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(261, 114);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(66, 25);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblKeySize
            // 
            this.lblKeySize.AutoSize = true;
            this.lblKeySize.Location = new System.Drawing.Point(39, 30);
            this.lblKeySize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKeySize.Name = "lblKeySize";
            this.lblKeySize.Size = new System.Drawing.Size(48, 13);
            this.lblKeySize.TabIndex = 1;
            this.lblKeySize.Text = "Key Size";
            // 
            // txtKeySize
            // 
            this.txtKeySize.Location = new System.Drawing.Point(101, 28);
            this.txtKeySize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKeySize.Name = "txtKeySize";
            this.txtKeySize.Size = new System.Drawing.Size(226, 20);
            this.txtKeySize.TabIndex = 2;
            this.txtKeySize.Text = "1024";
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(39, 58);
            this.lblSavePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(57, 13);
            this.lblSavePath.TabIndex = 1;
            this.lblSavePath.Text = "Save Path";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(101, 57);
            this.txtSavePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(226, 20);
            this.txtSavePath.TabIndex = 2;
            this.txtSavePath.Text = "c:\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Formats";
            // 
            // chkXmlFormat
            // 
            this.chkXmlFormat.AutoSize = true;
            this.chkXmlFormat.Checked = true;
            this.chkXmlFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXmlFormat.Location = new System.Drawing.Point(101, 84);
            this.chkXmlFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkXmlFormat.Name = "chkXmlFormat";
            this.chkXmlFormat.Size = new System.Drawing.Size(48, 17);
            this.chkXmlFormat.TabIndex = 3;
            this.chkXmlFormat.Text = "XML";
            this.chkXmlFormat.UseVisualStyleBackColor = true;
            // 
            // chkPemFormat
            // 
            this.chkPemFormat.AutoSize = true;
            this.chkPemFormat.Checked = true;
            this.chkPemFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPemFormat.Location = new System.Drawing.Point(161, 84);
            this.chkPemFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPemFormat.Name = "chkPemFormat";
            this.chkPemFormat.Size = new System.Drawing.Size(49, 17);
            this.chkPemFormat.TabIndex = 3;
            this.chkPemFormat.Text = "PEM";
            this.chkPemFormat.UseVisualStyleBackColor = true;
            // 
            // chkDerFormat
            // 
            this.chkDerFormat.AutoSize = true;
            this.chkDerFormat.Checked = true;
            this.chkDerFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDerFormat.Location = new System.Drawing.Point(209, 84);
            this.chkDerFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDerFormat.Name = "chkDerFormat";
            this.chkDerFormat.Size = new System.Drawing.Size(49, 17);
            this.chkDerFormat.TabIndex = 3;
            this.chkDerFormat.Text = "DER";
            this.chkDerFormat.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 144);
            this.Controls.Add(this.chkDerFormat);
            this.Controls.Add(this.chkPemFormat);
            this.Controls.Add(this.chkXmlFormat);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.lblKeySize);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Keys Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblKeySize;
        private System.Windows.Forms.TextBox txtKeySize;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkXmlFormat;
        private System.Windows.Forms.CheckBox chkPemFormat;
        private System.Windows.Forms.CheckBox chkDerFormat;
    }
}

