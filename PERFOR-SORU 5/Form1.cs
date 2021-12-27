using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERFOR_SORU_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            char b =char.Parse( textBox2.Text);
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)

                {

                    x++;
                }
            }
            label4.Text = x.ToString();
                

        }
    }
}
