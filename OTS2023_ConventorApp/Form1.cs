using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {

        double x = 0.45359237;
        public Form1()
        {
            InitializeComponent();
            rbWeight.Checked = true;
            

        }

        private void rbWeight_CheckedChanged(object sender, EventArgs e)
        {
            lbInput.Text = "Pounds";
            lbResult.Text = "KG";
            x = 0.45359237;
            txtInput.Text = "";
            txtResult.Text = "";
        }

        private void rbLength_CheckedChanged(object sender, EventArgs e)
        {
            lbInput.Text = "Feet";
            lbResult.Text = "Meters";
            x = 0.3048;
            txtInput.Text = "";
            txtResult.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtInput.Text) * x).ToString();
        }
    }
}
