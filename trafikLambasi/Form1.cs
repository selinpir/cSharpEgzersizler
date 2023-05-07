using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafikLambasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox2.Visible= false;//kırmızı
            pictureBox3.Visible = false;//sarı
            pictureBox4.Visible = false;//yeşil



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if(sayac==1)
            {
            pictureBox2.Visible = true;
            }

            if(sayac==30)
            {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            }

            if(sayac==50)
            {
                pictureBox3.Visible = false; 
                pictureBox4.Visible = true;
            }
            if (sayac==70)
            {
                pictureBox4.Visible = false;
                sayac = 0;
            }


        }
    }
}
