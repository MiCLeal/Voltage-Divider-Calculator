using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voltage.divisor.calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void TextBoxs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float vin;
                float r1;
                float r2;
                float vout = 0;

                if (txtVin.TextLength > 0 && txtR1.TextLength > 0 && txtR2.TextLength > 0)
                {
                    vin = Convert.ToSingle(txtVin.Text);
                    r1 = Convert.ToSingle(txtR1.Text);
                    r2 = Convert.ToSingle(txtR2.Text);
                    vout = Calc.DivisionCalc(vin, r1, r2);

                    
                }
                else
                {
                    vout = 0;
                }

                txtVout.Text = vout.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, ex.Source);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Clear();
            }
        }
    }
}
