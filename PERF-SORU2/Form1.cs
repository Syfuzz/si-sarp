using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERF_SORU2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Honore De Balzac":
                    textBox1.Text = "Vadideki Zambak";
                    label3.Text = "Antik Yayınevi–223 sayfa";
                    break;
                case "Charles Dickens":
                    textBox1.Text = "Büyük Umutlar";
                    label3.Text = "Can Yayınevi–588 sayfa";
                    break;
                case "Victor Hugo":
                    textBox1.Text = "Sefiller";
                    label3.Text = "İskele Yayıncılık–400 sayfa";
                    break;
                default:
                    MessageBox.Show("hata verildi bir yazar sectiğinizden emin olun!!!");
                    break;

            }
        }
    }
}
