namespace SkoleTools.Tools
{
    partial class MatematikUdregner
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
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.webResult = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(12, 12);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(432, 20);
            this.txtEquation.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 38);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(432, 27);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Udregn!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // webResult
            // 
            this.webResult.Location = new System.Drawing.Point(12, 71);
            this.webResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.webResult.Name = "webResult";
            this.webResult.Size = new System.Drawing.Size(432, 366);
            this.webResult.TabIndex = 8;
            // 
            // MatematikUdregner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 449);
            this.Controls.Add(this.webResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEquation);
            this.Name = "MatematikUdregner";
            this.Text = "Matematik Udregner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.WebBrowser webResult;
    }
}