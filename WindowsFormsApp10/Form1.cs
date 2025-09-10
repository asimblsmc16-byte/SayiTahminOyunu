using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int hak = 4;
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            Random rnd = new Random();
            sayi = rnd.Next(1, 10);
            label2.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tahmin;
            label3.Text = hak.ToString();
            tahmin = Convert.ToInt32(textBox1.Text);
            if (hak >= 0)
            {
                if (tahmin > sayi)
                {

                    label1.Text = "Azalt";
                    textBox1.Text = "";
                    hak = hak - 1;
                }
                else if (tahmin < sayi)
                {
                    label1.Text = "Yükselt";
                    textBox1.Text = "";
                    hak = hak - 1;
                }
                else
                {
                    textBox1.Text = "";
                    label1.Text = "Doğru !";
                }
            }
            else
            {
                panel1.Hide();
                MessageBox.Show("OYUN BİTTİ !!!");
                hak = 5;
                label3.Text = hak.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}