using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalC
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        internal string Operation = "";
        internal decimal FirstNumber;
        internal decimal SecondNumber;
        internal bool IsOperatorJustClick = false;
        internal bool IsResultJustDisplay = false;

        private void btnOne_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnOne);

        }

        private void GetOperator(Button btn)
        {
            Operation = btn.Text;
            FirstNumber = Convert.ToDecimal(txtResult.Text);
            IsOperatorJustClick = true;


        }
        private void GetBtnValue(Button btn)
        {
            var tempval = txtResult.Text + btn.Text;
            if(IsResultJustDisplay)
            {
               tempval= btn.Text;
               IsResultJustDisplay = false;
            }

           

            if (IsOperatorJustClick)
            {
                tempval = btn.Text;
                if (btn.Text == ".")
                {
                    tempval = "0" + btn.Text;
                }
                IsOperatorJustClick = false;
            }
            else
            {
                if (txtResult.Text.Length > 0)
                {
                    if (btn.Text == ".")
                    {
                        tempval = txtResult.Text + btn.Text;
                    }
                    else
                    {
                        tempval = Convert.ToDecimal(tempval).ToString();
                    }
                }

            }
            txtResult.Text = tempval;

        }

        private void GetResult()
        {

            switch (Operation)
            {
                case "+":
                    txtResult.Text = (FirstNumber + SecondNumber).ToString();
                    break;
                case "X":
                    txtResult.Text = (FirstNumber * SecondNumber).ToString();
                    break;
                case "-":
                    txtResult.Text = (FirstNumber - SecondNumber).ToString();
                    break;
                case "/":
                    txtResult.Text = (FirstNumber / SecondNumber).ToString();
                    break;

                default:
                    break;
            }
            IsResultJustDisplay = true; 
            Operation = "";

        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnTwo);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnThree);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnFour);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnFive);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnSix);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnSeven);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnEight);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnNine);
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if(!txtResult.Text.Contains('.'))
            {
                GetBtnValue(btnPoint);
            }
           
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            GetBtnValue(btnZero);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetOperator(btnPlus);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToDecimal(txtResult.Text);
            GetResult();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            GetOperator(btnMinus);

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            GetOperator(BtnMultiply);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            GetOperator(btnDivide);
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            Operation = "";
            IsOperatorJustClick = false;

        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            var tempvalue = Convert.ToDecimal(txtResult.Text) * -1;
            txtResult.Text = tempvalue.ToString();

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            var current = Convert.ToDecimal(txtResult.Text);
            txtResult.Text=(current / 100).ToString("0.00");
        }


    }
}
