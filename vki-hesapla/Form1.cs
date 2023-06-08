using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace vki_hesapla
{
    public partial class vki : Form
    {
        public vki()
        {
            InitializeComponent();
        }

        //  public double VKEHesapla()
        //{
        //  double vke = kilo / Math.Pow(boy, 2);
        //   return vke;
        // }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double kilo, boy;
            kilo = Convert.ToDouble(textBox1.Text);
            boy= Convert.ToDouble(textBox2.Text);
            double mboy = boy / 100;
            double sonuc = (kilo / (mboy * mboy));
            label3.Text=Convert.ToString(sonuc);

            if (sonuc < 18.5)
            {
                label4.Text = "zayıf";

            }
            if (sonuc>18.5 && sonuc<25)
            {
                label4.Text = "normal";
            }
            if (sonuc>25 &&sonuc<30)
            {
                label4.Text = "kilolu";
            }
            if(sonuc>30 && sonuc<40)
            {
                label4.Text = "obez";

            }
            if (sonuc>40)
            {
                label4.Text = "ağır obez";
                label4.ForeColor = Color.DarkRed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.ShowDialog(); 

        }

        private void vki_Load(object sender, EventArgs e)
        {

        }
    }
}
