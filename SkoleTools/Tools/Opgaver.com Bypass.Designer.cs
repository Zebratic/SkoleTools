namespace SkoleTools.Tools
{
    partial class OpgaverDotComBypass
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
            this.btnDownloadOpgave = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtOpgaven = new System.Windows.Forms.RichTextBox();
            this.lblEksempel = new System.Windows.Forms.Label();
            this.picPages = new System.Windows.Forms.PictureBox();
            this.cbHTTPMethod = new System.Windows.Forms.CheckBox();
            this.btnPictureBack = new System.Windows.Forms.Button();
            this.btnPictureForward = new System.Windows.Forms.Button();
            this.lblOpgaveInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownloadOpgave
            // 
            this.btnDownloadOpgave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadOpgave.Location = new System.Drawing.Point(12, 54);
            this.btnDownloadOpgave.Name = "btnDownloadOpgave";
            this.btnDownloadOpgave.Size = new System.Drawing.Size(626, 27);
            this.btnDownloadOpgave.TabIndex = 0;
            this.btnDownloadOpgave.Text = "Download Opgave";
            this.btnDownloadOpgave.UseVisualStyleBackColor = true;
            this.btnDownloadOpgave.Click += new System.EventHandler(this.btnDownloadOpgave_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(47, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(591, 20);
            this.txtURL.TabIndex = 1;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(9, 15);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "URL:";
            // 
            // txtOpgaven
            // 
            this.txtOpgaven.Location = new System.Drawing.Point(12, 87);
            this.txtOpgaven.Name = "txtOpgaven";
            this.txtOpgaven.ReadOnly = true;
            this.txtOpgaven.Size = new System.Drawing.Size(408, 333);
            this.txtOpgaven.TabIndex = 3;
            this.txtOpgaven.Text = "";
            // 
            // lblEksempel
            // 
            this.lblEksempel.AutoSize = true;
            this.lblEksempel.Location = new System.Drawing.Point(9, 36);
            this.lblEksempel.Name = "lblEksempel";
            this.lblEksempel.Size = new System.Drawing.Size(324, 13);
            this.lblEksempel.TabIndex = 4;
            this.lblEksempel.Text = "Eksempel:    https://opgaver.com/site/vis_opgave.php?id=158173";
            // 
            // picPages
            // 
            this.picPages.Location = new System.Drawing.Point(426, 87);
            this.picPages.Name = "picPages";
            this.picPages.Size = new System.Drawing.Size(212, 300);
            this.picPages.TabIndex = 5;
            this.picPages.TabStop = false;
            // 
            // cbHTTPMethod
            // 
            this.cbHTTPMethod.AutoSize = true;
            this.cbHTTPMethod.Checked = true;
            this.cbHTTPMethod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHTTPMethod.Location = new System.Drawing.Point(544, 35);
            this.cbHTTPMethod.Name = "cbHTTPMethod";
            this.cbHTTPMethod.Size = new System.Drawing.Size(94, 17);
            this.cbHTTPMethod.TabIndex = 6;
            this.cbHTTPMethod.Text = "HTTP Method";
            this.cbHTTPMethod.UseVisualStyleBackColor = true;
            // 
            // btnPictureBack
            // 
            this.btnPictureBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureBack.Location = new System.Drawing.Point(426, 393);
            this.btnPictureBack.Name = "btnPictureBack";
            this.btnPictureBack.Size = new System.Drawing.Size(103, 27);
            this.btnPictureBack.TabIndex = 7;
            this.btnPictureBack.Text = "<";
            this.btnPictureBack.UseVisualStyleBackColor = true;
            this.btnPictureBack.Click += new System.EventHandler(this.btnPictureBack_Click);
            // 
            // btnPictureForward
            // 
            this.btnPictureForward.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureForward.Location = new System.Drawing.Point(535, 393);
            this.btnPictureForward.Name = "btnPictureForward";
            this.btnPictureForward.Size = new System.Drawing.Size(103, 27);
            this.btnPictureForward.TabIndex = 8;
            this.btnPictureForward.Text = ">";
            this.btnPictureForward.UseVisualStyleBackColor = true;
            this.btnPictureForward.Click += new System.EventHandler(this.btnPictureForward_Click);
            // 
            // lblOpgaveInfo
            // 
            this.lblOpgaveInfo.AutoSize = true;
            this.lblOpgaveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpgaveInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOpgaveInfo.Location = new System.Drawing.Point(644, 12);
            this.lblOpgaveInfo.Name = "lblOpgaveInfo";
            this.lblOpgaveInfo.Size = new System.Drawing.Size(91, 396);
            this.lblOpgaveInfo.TabIndex = 9;
            this.lblOpgaveInfo.Text = "Titel:\r\n\r\n\r\nBruger:\r\n\r\n\r\nFag:\r\n\r\n\r\nUploadet:\r\n\r\n\r\nKlassetrin:\r\n\r\n\r\nAntal sider:\r\n" +
    "\r\n\r\nDownloadet:\r\n\r\n\r\nRating:\r\n";
            // 
            // OpgaverDotComBypass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 432);
            this.Controls.Add(this.lblOpgaveInfo);
            this.Controls.Add(this.btnPictureForward);
            this.Controls.Add(this.btnPictureBack);
            this.Controls.Add(this.cbHTTPMethod);
            this.Controls.Add(this.picPages);
            this.Controls.Add(this.lblEksempel);
            this.Controls.Add(this.txtOpgaven);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnDownloadOpgave);
            this.Name = "OpgaverDotComBypass";
            this.Text = "Opgaver";
            ((System.ComponentModel.ISupportInitialize)(this.picPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadOpgave;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.RichTextBox txtOpgaven;
        private System.Windows.Forms.Label lblEksempel;
        private System.Windows.Forms.PictureBox picPages;
        private System.Windows.Forms.CheckBox cbHTTPMethod;
        private System.Windows.Forms.Button btnPictureBack;
        private System.Windows.Forms.Button btnPictureForward;
        private System.Windows.Forms.Label lblOpgaveInfo;
    }
}