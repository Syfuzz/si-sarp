using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERF_SORU_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aci,aci1=int.Parse(textBox1.Text),aci2=int.Parse(textBox2.Text) ;
            aci = 180 -(aci1-aci2);
            
            if(aci<90)
            {
                label3.Text = "DAR ACILI ÜÇGEN";


            }
            else if(aci>90)
            {
                label3.Text = "GENİŞ ACILI ÜÇGEN";

            }
            else if(aci==90)
            {
                label3.Text = "DİK ACILI ÜÇGEN";

            }
            else
            {
                MessageBox.Show("hata");
            }
            
        }
    }
}
