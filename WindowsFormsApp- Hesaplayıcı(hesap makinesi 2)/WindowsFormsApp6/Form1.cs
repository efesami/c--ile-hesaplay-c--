using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6AALIŞTIRMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1artı_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuç = (sayi1 + sayi2);
            textBox3.Text = sonuç.ToString();
        }

        private void button2eksi_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuç = (sayi1 - sayi2);
            textBox3.Text = sonuç.ToString();
        }

        private void button3çarpı_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuç = (sayi1 * sayi2);
            textBox3.Text = sonuç.ToString();
        }

        private void button4bölü_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuç = (sayi1 / sayi2);
            textBox3.Text = sonuç.ToString();
        }

        private void button2temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hesaplayıcıya Hoş Geldiniz..", "Hesaplayıcı");
            BackColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox3.TextAlign = HorizontalAlignment.Right;
            this.Text = "Hesaplayıcı";  // form başlığını değiştirdik



        }


    }
}
