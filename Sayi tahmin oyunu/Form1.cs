using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayi_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int rastgele,tahmin , hak = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hak--;
            tahmin = Convert.ToInt32(textBox1.Text);
            if (rastgele == tahmin)
            {

                MessageBox.Show("Tebrikler Bildiniz");
                hak = 3;
                label1.Text = "Hak=" + hak;
            }


            else
            {
                MessageBox.Show("Uzgunum Bilemediniz");
                label1.Text = "Hak=" + hak;
                
                if(hak == 0)
                {
                    MessageBox.Show("Hakkiniz kalmamistir");
                    textBox1.Enabled = false;
                    btn1.Enabled = false;
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rastgele = rnd.Next(0, 100);
            
        }
    }
}
