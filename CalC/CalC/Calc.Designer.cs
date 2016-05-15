namespace CalC
{
    partial class Calc
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
            this.btnAC = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAC.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAC.Location = new System.Drawing.Point(1, 74);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(72, 72);
            this.btnAC.TabIndex = 0;
            this.btnAC.Text = "C";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("OpenSymbol", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.Info;
            this.txtResult.Location = new System.Drawing.Point(6, 7);
            this.txtResult.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.txtResult.MaxLength = 15;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(271, 41);
            this.txtResult.TabIndex = 1;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 71);
            this.panel1.TabIndex = 2;
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPM.Location = new System.Drawing.Point(74, 74);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(72, 72);
            this.btnPM.TabIndex = 3;
            this.btnPM.Text = "+/-";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPercent.Location = new System.Drawing.Point(147, 74);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(72, 72);
            this.btnPercent.TabIndex = 4;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnDivide.Location = new System.Drawing.Point(220, 74);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(72, 72);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnMultiply.Location = new System.Drawing.Point(220, 148);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(72, 72);
            this.BtnMultiply.TabIndex = 6;
            this.BtnMultiply.Text = "X";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnMinus.Location = new System.Drawing.Point(220, 221);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(72, 72);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnPlus.Location = new System.Drawing.Point(220, 294);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(72, 72);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEqual.Location = new System.Drawing.Point(219, 367);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(72, 72);
            this.btnEqual.TabIndex = 9;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.Menu;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNine.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.Color.Black;
            this.btnNine.Location = new System.Drawing.Point(147, 148);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(72, 72);
            this.btnNine.TabIndex = 12;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEight.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.Color.Black;
            this.btnEight.Location = new System.Drawing.Point(74, 148);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(72, 72);
            this.btnEight.TabIndex = 11;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSeven.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.Color.Black;
            this.btnSeven.Location = new System.Drawing.Point(1, 148);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(72, 72);
            this.btnSeven.TabIndex = 10;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSix.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.Color.Black;
            this.btnSix.Location = new System.Drawing.Point(147, 221);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(72, 72);
            this.btnSix.TabIndex = 15;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.Menu;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFive.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.Color.Black;
            this.btnFive.Location = new System.Drawing.Point(74, 221);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(72, 72);
            this.btnFive.TabIndex = 14;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.Menu;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFour.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.Color.Black;
            this.btnFour.Location = new System.Drawing.Point(1, 221);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(72, 72);
            this.btnFour.TabIndex = 13;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.Menu;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThree.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.Color.Black;
            this.btnThree.Location = new System.Drawing.Point(147, 294);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(72, 72);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.Menu;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTwo.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.Color.Black;
            this.btnTwo.Location = new System.Drawing.Point(74, 294);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(72, 72);
            this.btnTwo.TabIndex = 17;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.Menu;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOne.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.Color.Black;
            this.btnOne.Location = new System.Drawing.Point(1, 294);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(72, 72);
            this.btnOne.TabIndex = 16;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPoint.ForeColor = System.Drawing.Color.Black;
            this.btnPoint.Location = new System.Drawing.Point(146, 367);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(72, 72);
            this.btnPoint.TabIndex = 19;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.Menu;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnZero.ForeColor = System.Drawing.Color.Black;
            this.btnZero.Location = new System.Drawing.Point(1, 367);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(144, 72);
            this.btnZero.TabIndex = 20;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 445);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calc";
            this.Text = "Basic Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnZero;
    }
}

