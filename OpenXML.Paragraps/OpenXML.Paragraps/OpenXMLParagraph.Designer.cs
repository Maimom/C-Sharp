namespace OpenXML.Paragraps
{
    partial class OpenXMLParagraph
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtParagraph = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkDocx = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FontList = new System.Windows.Forms.ComboBox();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(216, 39);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(302, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Where you want to create the document";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(518, 37);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(24, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Give your Document a Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(216, 78);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(244, 21);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Text = "SampleDocument";
            // 
            // txtParagraph
            // 
            this.txtParagraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParagraph.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParagraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtParagraph.Location = new System.Drawing.Point(12, 166);
            this.txtParagraph.Name = "txtParagraph";
            this.txtParagraph.Size = new System.Drawing.Size(551, 252);
            this.txtParagraph.TabIndex = 7;
            this.txtParagraph.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(418, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkDocx
            // 
            this.checkDocx.AutoSize = true;
            this.checkDocx.Checked = true;
            this.checkDocx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDocx.Enabled = false;
            this.checkDocx.Location = new System.Drawing.Point(466, 81);
            this.checkDocx.Name = "checkDocx";
            this.checkDocx.Size = new System.Drawing.Size(52, 17);
            this.checkDocx.TabIndex = 10;
            this.checkDocx.Text = ".docx";
            this.checkDocx.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select font";
            // 
            // FontList
            // 
            this.FontList.FormattingEnabled = true;
            this.FontList.Location = new System.Drawing.Point(216, 114);
            this.FontList.Name = "FontList";
            this.FontList.Size = new System.Drawing.Size(187, 21);
            this.FontList.TabIndex = 12;
            this.FontList.Text = "Arial";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(459, 115);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(59, 20);
            this.fontSize.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Font Size";
            // 
            // OpenXMLParagraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.FontList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkDocx);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtParagraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.MaximizeBox = false;
            this.Name = "OpenXMLParagraph";
            this.Text = "Creat a Word Document";
            this.Load += new System.EventHandler(this.OpenXMLParagraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.RichTextBox txtParagraph;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkDocx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FontList;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label label4;
    }
}

