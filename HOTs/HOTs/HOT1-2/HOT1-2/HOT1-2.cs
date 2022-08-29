using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtNumber3.Text = "";
            txtAverage.Text = "";
            txtNumber1.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?",
                                           "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCalulate_Click(object sender, EventArgs e)
        {
            int Number1 = Convert.ToInt32(txtNumber1.Text);
            int Number2 = Convert.ToInt32(txtNumber2.Text);
            int Number3 = Convert.ToInt32(txtNumber3.Text);
            int totNumber = Number1 + Number2 + Number3;
            decimal Average = totNumber / 3.0m;
            txtAverage.Text = Average.ToString("n2");
        }
    }
}
