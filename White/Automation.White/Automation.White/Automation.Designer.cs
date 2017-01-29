namespace Automation.White
{
    partial class Automation
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
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.Location = new System.Drawing.Point(382, 177);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(123, 51);
            this.btnGetStarted.TabIndex = 0;
            this.btnGetStarted.Text = "&Get Started";
            this.btnGetStarted.UseVisualStyleBackColor = true;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // Automation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.btnGetStarted);
            this.Name = "Automation";
            this.Text = "Automation  using white";
            this.Load += new System.EventHandler(this.Automation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetStarted;
    }
}

