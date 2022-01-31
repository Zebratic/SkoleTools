namespace SkoleTools
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
            this.cbTools = new System.Windows.Forms.ComboBox();
            this.gbTool = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cbTools
            // 
            this.cbTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTools.FormattingEnabled = true;
            this.cbTools.Location = new System.Drawing.Point(12, 12);
            this.cbTools.Name = "cbTools";
            this.cbTools.Size = new System.Drawing.Size(640, 21);
            this.cbTools.TabIndex = 0;
            this.cbTools.SelectedIndexChanged += new System.EventHandler(this.cbTools_SelectedIndexChanged);
            // 
            // gbTool
            // 
            this.gbTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTool.Location = new System.Drawing.Point(12, 39);
            this.gbTool.Name = "gbTool";
            this.gbTool.Size = new System.Drawing.Size(640, 320);
            this.gbTool.TabIndex = 1;
            this.gbTool.TabStop = false;
            this.gbTool.Text = "Tool Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 371);
            this.Controls.Add(this.gbTool);
            this.Controls.Add(this.cbTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Skole Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTools;
        private System.Windows.Forms.GroupBox gbTool;
    }
}

