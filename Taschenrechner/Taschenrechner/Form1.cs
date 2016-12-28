using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{


    public partial class Form1 : Form
    {

        double currentvalue = 0;
        bool addcheck = false;
        bool subcheck = false;
        bool mulcheck = false;
        bool divcheck = false;
        bool newcalccheck = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void ErrorReset()
        {
            txtboxcalc.Text = " ";
            txtboxnumbers.Text = " ";
            txtboxresult.Text = " ";
            MessageBox.Show("ERROR please follow steps on the right ERROR");
            Checkneutralizer();
            newcalccheck = true;
        }

        public void Checkneutralizer()
        {
            addcheck = false;
            subcheck = false;
            mulcheck = false;
            divcheck = false;
        }

        public void NewCalcChecker()
        {
            if (newcalccheck == true)
            {
                txtboxcalc.Text = "";
                newcalccheck = false;
            }
        }

        

        private void btn1_Click(object sender, EventArgs e)
        {
            NewCalcChecker();
            txtboxnumbers.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NewCalcChecker();
            txtboxnumbers.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NewCalcChecker();
            txtboxnumbers.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NewCalcChecker();
            txtboxnumbers.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NewCalcChecker();
            txtboxnumbers.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NewCalcChecker();
            txtboxnumbers.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NewCalcChecker();
            txtboxnumbers.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NewCalcChecker();
            txtboxnumbers.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NewCalcChecker();
            txtboxnumbers.Text += 9;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(txtboxnumbers.TextLength>0)
            txtboxnumbers.Text = txtboxnumbers.Text.Substring(0, txtboxnumbers.TextLength - 1);
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            txtboxcalc.Text += txtboxnumbers.Text;
            if (addcheck==true)
            {
                currentvalue = currentvalue + Convert.ToDouble(txtboxnumbers.Text);
            }
            if (subcheck == true)
            {
                currentvalue = currentvalue - Convert.ToDouble(txtboxnumbers.Text);
            }
            if (mulcheck == true)
            {
                currentvalue = currentvalue * Convert.ToDouble(txtboxnumbers.Text);
            }
            if (divcheck == true)
            {
                currentvalue = currentvalue / Convert.ToDouble(txtboxnumbers.Text);
            }
            txtboxresult.Text = currentvalue.ToString();
            txtboxnumbers.Text = "";
            currentvalue = 0;
            Checkneutralizer();
            newcalccheck = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
                {
                if (addcheck == false && mulcheck == false && divcheck == false && subcheck == false)
                {
                    Checkneutralizer();
                    addcheck = true;
                    txtboxcalc.Text += txtboxnumbers.Text + " + ";
                    currentvalue = Convert.ToDouble(txtboxnumbers.Text);
                    txtboxnumbers.Text = "";
                }
            }
            catch
            {
                ErrorReset();
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (addcheck == false && mulcheck == false && divcheck == false && subcheck == false)
                {
                    Checkneutralizer();
                    subcheck = true;
                    txtboxcalc.Text += txtboxnumbers.Text + " - ";
                    currentvalue = Convert.ToDouble(txtboxnumbers.Text);
                    txtboxnumbers.Text = "";
                }
            }
            catch
            {
                ErrorReset();
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            try
            {
                if (addcheck == false && mulcheck == false && divcheck == false && subcheck == false)
                {
                    Checkneutralizer();
                    mulcheck = true;
                    txtboxcalc.Text += txtboxnumbers.Text + " * ";
                    currentvalue = Convert.ToDouble(txtboxnumbers.Text);
                    txtboxnumbers.Text = "";
                }
            }
            catch
            {
                ErrorReset();
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            try
            {
                if (addcheck == false && mulcheck == false && divcheck == false && subcheck == false)
                {
                    Checkneutralizer();
                    divcheck = true;
                    txtboxcalc.Text += txtboxnumbers.Text + " / ";
                    currentvalue = Convert.ToDouble(txtboxnumbers.Text);
                    txtboxnumbers.Text = "";
                }
            }
            catch
            {
                ErrorReset();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtboxnumbers.Text += 0;
        }

       

        
    }
}
