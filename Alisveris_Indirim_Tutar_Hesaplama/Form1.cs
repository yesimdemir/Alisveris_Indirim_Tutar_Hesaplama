using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alisveris_Indirim_Tutar_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double toplam;
            adet = Convert.ToInt16(textBox1.Text);
            if(adet >= 0 && adet <= 20 )
            {
                toplam = (adet * 8) * 0.8;
                label3.Text = toplam + "TL";
            }
            if(adet> 20 && adet <= 40)
            {
                toplam = (adet * 8) * 0.6;
                label3.Text = toplam + "TL";
            }
            if (adet > 40)
            {
                toplam = (adet * 8) * 0.5;
                label3.Text = toplam + "TL";
            }
        }
    }
}
