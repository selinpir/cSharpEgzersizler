using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1
{
           /*  Trafik ışığı simülasyonu(form)

              * Kırmızı 45 sn yansın
              * Sarı ile kırmızı birlikte 2 saniye yanıp sönecek
              * Yeşil yanacak 30 sn.
              * Yeşil 3 sn yanıp sönecek
              * Kalan süre de gösterilecek --→ Kırmızı geri sayarken kırmızı ile gösterilecek, yeşil geriye sayarken yeşik ile gösterilecek from üzernde yap
              */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          //  panel1.BackColor = Color.Red;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.Yellow;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // panel1.BackColor = Color.Green;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label4.Text = sayac.ToString();
            if (sayac >= 0 && sayac < 45)
            {
                panel1.BackColor = Color.Red;
                label1.Text = sayac.ToString();              
            }
            if (sayac == 45)
            {
                panel1.BackColor = Color.White;
            }

            if (sayac >= 45 && sayac < 47)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Yellow;
                label2.Text = sayac.ToString();              
            }
            if (sayac == 47)
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.White;
            }

            if (sayac >= 47 && sayac< 97)
            {
                panel3.BackColor = Color.Green;
                label3.Text = sayac.ToString();
               
            }

            if (sayac == 97)
            { panel3.BackColor = Color.White; }

            if (sayac >= 97 && sayac <= 100)
            {
                panel3.BackColor = Color.Green;
                sayac = 0;
            }
            if (sayac == 0)
            { panel3.BackColor = Color.White; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
