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
            this.components = new System.ComponentModel.Container();
            this.btnDownloadOpgave = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtOpgaven = new System.Windows.Forms.RichTextBox();
            this.lblEksempel = new System.Windows.Forms.Label();
            this.cbHTTPMethod = new System.Windows.Forms.CheckBox();
            this.btnPictureBack = new System.Windows.Forms.Button();
            this.btnPictureForward = new System.Windows.Forms.Button();
            this.lblOpgaveInfo = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadBilledeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFixFormat = new System.Windows.Forms.Button();
            this.btnDownloadDocx = new System.Windows.Forms.Button();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.picPages = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownloadOpgave
            // 
            this.btnDownloadOpgave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadOpgave.Location = new System.Drawing.Point(5, 104);
            this.btnDownloadOpgave.Name = "btnDownloadOpgave";
            this.btnDownloadOpgave.Size = new System.Drawing.Size(626, 27);
            this.btnDownloadOpgave.TabIndex = 0;
            this.btnDownloadOpgave.Text = "Download Opgave";
            this.btnDownloadOpgave.UseVisualStyleBackColor = true;
            this.btnDownloadOpgave.Click += new System.EventHandler(this.btnDownloadOpgave_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(40, 62);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(591, 20);
            this.txtURL.TabIndex = 1;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(2, 65);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "URL:";
            // 
            // txtOpgaven
            // 
            this.txtOpgaven.Location = new System.Drawing.Point(5, 137);
            this.txtOpgaven.Name = "txtOpgaven";
            this.txtOpgaven.ReadOnly = true;
            this.txtOpgaven.Size = new System.Drawing.Size(408, 333);
            this.txtOpgaven.TabIndex = 3;
            this.txtOpgaven.Text = "";
            // 
            // lblEksempel
            // 
            this.lblEksempel.AutoSize = true;
            this.lblEksempel.Location = new System.Drawing.Point(2, 86);
            this.lblEksempel.Name = "lblEksempel";
            this.lblEksempel.Size = new System.Drawing.Size(324, 13);
            this.lblEksempel.TabIndex = 4;
            this.lblEksempel.Text = "Eksempel:    https://opgaver.com/site/vis_opgave.php?id=158173";
            // 
            // cbHTTPMethod
            // 
            this.cbHTTPMethod.AutoSize = true;
            this.cbHTTPMethod.Checked = true;
            this.cbHTTPMethod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHTTPMethod.Location = new System.Drawing.Point(537, 85);
            this.cbHTTPMethod.Name = "cbHTTPMethod";
            this.cbHTTPMethod.Size = new System.Drawing.Size(94, 17);
            this.cbHTTPMethod.TabIndex = 6;
            this.cbHTTPMethod.Text = "HTTP Method";
            this.cbHTTPMethod.UseVisualStyleBackColor = true;
            // 
            // btnPictureBack
            // 
            this.btnPictureBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureBack.Location = new System.Drawing.Point(419, 443);
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
            this.btnPictureForward.Location = new System.Drawing.Point(528, 443);
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
            this.lblOpgaveInfo.Location = new System.Drawing.Point(637, 62);
            this.lblOpgaveInfo.Name = "lblOpgaveInfo";
            this.lblOpgaveInfo.Size = new System.Drawing.Size(91, 396);
            this.lblOpgaveInfo.TabIndex = 9;
            this.lblOpgaveInfo.Text = "Titel:\r\n\r\n\r\nBruger:\r\n\r\n\r\nFag:\r\n\r\n\r\nUploadet:\r\n\r\n\r\nKlassetrin:\r\n\r\n\r\nAntal sider:\r\n" +
    "\r\n\r\nDownloadet:\r\n\r\n\r\nRating:\r\n";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadBilledeToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(167, 26);
            // 
            // downloadBilledeToolStripMenuItem
            // 
            this.downloadBilledeToolStripMenuItem.Name = "downloadBilledeToolStripMenuItem";
            this.downloadBilledeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.downloadBilledeToolStripMenuItem.Text = "Download Billede";
            this.downloadBilledeToolStripMenuItem.Click += new System.EventHandler(this.downloadBilledeToolStripMenuItem_Click);
            // 
            // btnFixFormat
            // 
            this.btnFixFormat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixFormat.Location = new System.Drawing.Point(5, 476);
            this.btnFixFormat.Name = "btnFixFormat";
            this.btnFixFormat.Size = new System.Drawing.Size(626, 27);
            this.btnFixFormat.TabIndex = 11;
            this.btnFixFormat.Text = "Fix Format";
            this.btnFixFormat.UseVisualStyleBackColor = true;
            this.btnFixFormat.Click += new System.EventHandler(this.btnFixFormat_Click);
            // 
            // btnDownloadDocx
            // 
            this.btnDownloadDocx.Enabled = false;
            this.btnDownloadDocx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadDocx.Location = new System.Drawing.Point(5, 509);
            this.btnDownloadDocx.Name = "btnDownloadDocx";
            this.btnDownloadDocx.Size = new System.Drawing.Size(626, 27);
            this.btnDownloadDocx.TabIndex = 12;
            this.btnDownloadDocx.Text = "Download .docx";
            this.btnDownloadDocx.UseVisualStyleBackColor = true;
            // 
            // picBanner
            // 
            this.picBanner.BackgroundImage = global::SkoleTools.Properties.Resources.logo;
            this.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(631, 56);
            this.picBanner.TabIndex = 13;
            this.picBanner.TabStop = false;
            // 
            // picPages
            // 
            this.picPages.Location = new System.Drawing.Point(419, 137);
            this.picPages.Name = "picPages";
            this.picPages.Size = new System.Drawing.Size(212, 300);
            this.picPages.TabIndex = 5;
            this.picPages.TabStop = false;
            this.picPages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPages_MouseClick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(5, 542);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(626, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(5, 593);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(626, 45);
            this.trackBar2.TabIndex = 15;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // OpgaverDotComBypass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 676);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.btnDownloadDocx);
            this.Controls.Add(this.btnFixFormat);
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
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem downloadBilledeToolStripMenuItem;
        private System.Windows.Forms.Button btnFixFormat;
        private System.Windows.Forms.Button btnDownloadDocx;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}