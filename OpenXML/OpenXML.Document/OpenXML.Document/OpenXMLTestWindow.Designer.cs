namespace OpenXML.Document
{
    partial class OpenXMLTestWindow
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
            this.btnGenDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenDoc
            // 
            this.btnGenDoc.Location = new System.Drawing.Point(516, 46);
            this.btnGenDoc.Name = "btnGenDoc";
            this.btnGenDoc.Size = new System.Drawing.Size(149, 53);
            this.btnGenDoc.TabIndex = 0;
            this.btnGenDoc.Text = "Generate Document";
            this.btnGenDoc.UseVisualStyleBackColor = true;
            // 
            // OpenXMLTestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 317);
            this.Controls.Add(this.btnGenDoc);
            this.Name = "OpenXMLTestWindow";
            this.Text = "Open XML Test ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenDoc;
    }
}

