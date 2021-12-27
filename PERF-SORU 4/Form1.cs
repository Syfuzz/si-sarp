using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERF_SORU_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                double b = 10 + (a - 8) * 1.5;

                label3.Text = b.ToString();
            }
            else if (radioButton2.Checked)
            {
                double b = 12 + (a - 10) * 1.7;
                label3.Text = b.ToString();
            }
            else if (radioButton3.Checked)
            {
                double b = 8 + (a - 12) * 0.8;
                label3.Text = b.ToString();
            }
        }
    }
}
