using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vki_hesapla
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo = Convert.ToDouble(textBox1.Text);
            double boy = Convert.ToDouble(textBox2.Text);

            double vki = kilo / Math.Pow(boy, 2);
            double idealVKI = 24.9;
           // double idealKilo = idealVKI * Math.Pow(boy, 2);
            double almasiGerekenKilo = idealVKI  - kilo;
            double vermesiGerekenKilo = kilo - idealVKI ;

            label3.Text = Convert.ToString(vki);
            label6.Text = almasiGerekenKilo.ToString("F2");
            label7.Text = vermesiGerekenKilo.ToString("F2");

            //label3.Text = Convert.ToString(vki);
            //label6.Text = Convert.ToString(almasiGerekenKilo);
       //     label7.Text = Convert.ToString(vermesiGerekenKilo);
        }
    }
}
