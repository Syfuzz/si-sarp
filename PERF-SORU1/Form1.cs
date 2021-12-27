using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERF_SORU1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int akım = int.Parse(textBox1.Text), direnc =int.Parse (textBox2.Text),güc;
            güc = (akım * akım) * direnc;
            label4.Text = güc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int akım = int.Parse(textBox1.Text), direnc = int.Parse(textBox2.Text), gerilim;
            gerilim = akım  * direnc;
            label4.Text = gerilim.ToString();
        }
    }
}
