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

namespace zar_atma_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global degiskenler
        Random rastgele =new Random();
        int oyuncu1toplam, oyuncu2toplam=0;
        int a, b;

        private void zar_at()
        {
            a =rastgele.Next(1,7);
            b = rastgele.Next(1,7);
            //oyuncu 1 için
            if (a == 1)
            {   pictureBox1.ImageLocation = "zar_img\\1.png"; }
            if (a == 2)
            { pictureBox1.ImageLocation = "zar_img\\2.png"; }
            if (a == 3)
            { pictureBox1.ImageLocation = "zar_img\\3.png"; }
            if (a == 4)
            { pictureBox1.ImageLocation = "zar_img\\4.png"; }
            if (a == 5)
            { pictureBox1.ImageLocation = "zar_img\\5.png"; }
            if (a == 6)
            { pictureBox1.ImageLocation = "zar_img\\6.png"; }
            if (a == 7)
            { pictureBox1.ImageLocation = "zar_img\\7.png"; }


            //oyuncu 2 için
            if (b == 1)
            { pictureBox2.ImageLocation = "zar_img\\1.png"; }
            if (b == 2)
            { pictureBox2.ImageLocation = "zar_img\\2.png"; }
            if (b == 3)
            { pictureBox2.ImageLocation = "zar_img\\3.png"; }
            if (b == 4)
            { pictureBox2.ImageLocation = "zar_img\\4.png"; }
            if (b == 5)
            { pictureBox2.ImageLocation = "zar_img\\5.png"; }
            if (b == 6)
            { pictureBox2.ImageLocation = "zar_img\\6.png"; }
            if (b == 7)
            { pictureBox2.ImageLocation = "zar_img\\7.png"; }
        }

        private void oyuncuSkor()
        {
            if (oyuncu1toplam >= Convert.ToInt32(textBox1.Text))
            {
                label6.Visible = true;
                label6.Text = "Oyuncu 1 kazandı :) Tebrikler";
                button3.Visible = true;
                button2.Enabled = false;
                button1.Enabled = false; // Disable player 1 button when player 1 wins
            }

            if (oyuncu2toplam >= Convert.ToInt32(textBox1.Text))
            {
                label6.Visible = true;
                label6.Text = "Oyuncu 2 kazandı :) Tebrikler";
                button3.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false; // Disable player 2 button when player 2 wins
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //oyuncu 1

            textBox1.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible=true;
            button1.Enabled=false;
            button2.Enabled=true;
            zar_at();
            oyuncu1toplam = oyuncu1toplam + a + b;
            label3.Text=oyuncu1toplam.ToString();
            oyuncuSkor();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //oyuncu 2
            textBox1.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button2.Enabled = false;
            button1.Enabled = true;
            zar_at();
            oyuncu2toplam = oyuncu2toplam + a + b;
            label4.Text = oyuncu2toplam.ToString();
            oyuncuSkor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //oyuna tekrar basla
            textBox1.Enabled= true;
            textBox1.Text = "100";
            button1.Enabled=true;
            button2.Enabled=true;

            label4.Enabled = true;
            textBox1.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            oyuncu1toplam = 0;
            oyuncu2toplam = 0;
            label4.Text = "0";
            label3.Text = "0";
            label6.Visible = false;
            button3.Visible = false;
        }
    }
}
