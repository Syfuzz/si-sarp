using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERF_SORU_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(comboBox1.Text),c;
            for (int x = 0; x <= 10; x++)
            {
                for (int i = 0; i <= 10; i++)
                {
                    c = a * i;
                    label1.Text = a + " " + "*" + " " + i + " " + "=" + c+"\n";
                }
            }
        }
    }
}
