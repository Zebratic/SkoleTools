namespace SkoleTools.Tools
{
    partial class SkjultBrowser
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
            this.txtURL = new System.Windows.Forms.ComboBox();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtURL.FormattingEnabled = true;
            this.txtURL.Location = new System.Drawing.Point(0, 0);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(800, 21);
            this.txtURL.TabIndex = 3;
            this.txtURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyUp);
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(0, 21);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(800, 429);
            this.WebBrowser.TabIndex = 4;
            // 
            // SkjultBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.txtURL);
            this.Name = "SkjultBrowser";
            this.Text = "Skjult Browser";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox txtURL;
        private System.Windows.Forms.WebBrowser WebBrowser;
    }
}