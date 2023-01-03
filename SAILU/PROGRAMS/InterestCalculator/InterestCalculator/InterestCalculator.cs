using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class InterestCalculator : Form
    {
        public InterestCalculator()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrincipal.Text))
            {
                MessageBox.Show("Please Enter Principal ");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRate.Text))
            {
                MessageBox.Show("Please Enter Interest Rate ");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("Please Enter Time Period ");
                return;
            }

            double Principal = 0;

            if (!string.IsNullOrWhiteSpace(txtPrincipal.Text))
            {                
                bool IsNumber = double.TryParse(txtPrincipal.Text, out Principal);
                if (!IsNumber)
                {
                    MessageBox.Show("Please Enter Valid Principal");
                    return;
                }
            }

            double Rate = 0;

            if (!string.IsNullOrWhiteSpace(txtRate.Text))
            {
                bool IsNumber = double.TryParse(txtRate.Text, out Rate);
                if (!IsNumber)
                {
                    MessageBox.Show("Please Enter Valid Interest Rate");
                    return;
                }
            }

            int Time = 0;

            if (!string.IsNullOrWhiteSpace(txtTime.Text))
            {
                bool IsNumber = int.TryParse(txtTime.Text, out Time);
                if (!IsNumber)
                {
                    MessageBox.Show("Please Enter Valid Time Period");
                    return;
                }
            }

            CalculateInterest(Principal, Rate, Time);
        }

        private void CalculateInterest(double Principal, double Rate, int Time)
        {
            double SI = (Principal * Time * Rate) / 100;
            double SIT = Principal + SI;
            int IntegerSIT = Convert.ToInt32(SIT);

            double CIT = Principal * (Math.Pow((1 + (Rate / 100)),  Time));
            int IntegerCIT = Convert.ToInt32(CIT);

            txtSimpleInterest.Text = IntegerSIT.ToString();
            txtCompoundInterest.Text = IntegerCIT.ToString();
        }
    }
}
