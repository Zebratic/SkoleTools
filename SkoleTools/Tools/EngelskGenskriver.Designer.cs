namespace SkoleTools.Tools
{
    partial class EngelskGenskriver
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
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnRewrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(408, 333);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(426, 12);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(408, 333);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            // 
            // btnRewrite
            // 
            this.btnRewrite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRewrite.Location = new System.Drawing.Point(12, 351);
            this.btnRewrite.Name = "btnRewrite";
            this.btnRewrite.Size = new System.Drawing.Size(822, 27);
            this.btnRewrite.TabIndex = 6;
            this.btnRewrite.Text = "Genskriv!";
            this.btnRewrite.UseVisualStyleBackColor = true;
            this.btnRewrite.Click += new System.EventHandler(this.btnRewrite_Click);
            // 
            // EngelskGenskriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 397);
            this.Controls.Add(this.btnRewrite);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "EngelskGenskriver";
            this.Text = "Genskriv (Engelsk)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnRewrite;
    }
}