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

namespace randomquote
{
    public partial class Form1 : Form
    {
        private Random random;
        // private RichTextBox alinti;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.ReadOnly = true;

            string[] alinti = {
                "Acı bir armağandır. Acı hissimiz olmasaydı, verdiğimiz acıyı hissedemezdik.- Doctor Who\r\n",
                 "\v Filizlendikten sonra bir fikri, asla öldüremezsiniz.-Sherlock\r\n",
                  "\v Bu dünyadan özgür bir adam olarak gitmek kadar büyük bir zafer yoktur.- Spartacus\r\n",
                   "\v İnsanlar size kim olduklarını anlatırlar ama biz inanmayız.\vÇünkü biz onların, olmasını istediğimiz kişiler olmalarını isteriz.- Mad Man\r\n",
                    "\v Suya dinamit atana kadar balık tutmaya devam edebilirsin.-  The Big Bang Theory\r\n",
                     "\v Eğer her bir saman tanesi bilgisayara kaydedildiyse, samanlıkta iğne aramak o kadar da zor değildir.- Dexter\r\n",
                      "\v Neden bizi fark edenleri değil de, fark etmeyenleri isteriz?- Shameless\r\n",
                       "\v Duygu denen şey, sadece kaybeden tarafta bulunan kimyasal bir kusurdur. Her zaman aşkın, tehlikeli bir dezavantaj olduğunu varsaymışımdır.- Sherlock\r\n",
                        "\v Nefret etmemek o kadar zor ki… İnsanlardan, eşyalardan, geleneklerden. Senin azmini kırıp kanamanı izlerken, zevkten dört köşe olduklarında, mantıklı gelen tek his nefret oluyor. Ama ben nefretin insanı ne hale getirdiğini biliyorum. Nefret insanı paramparça eder. Olmadığı birisine dönüştürür. Hiçbir zaman dönüşmeyeceğine söz verdiği birisine.Sons of Anarchy\r\n",
                         "\v Herkes yalnız ölür ama birileri için bir şey ifade ettiysen, birilerine yardım ettiysen ya da birilerini sevdiysen, tek bir kişi bile seni hatırlıyorsa belki de aslında hiç ölmezsin.- Person of Interest\r\n",
            };
            int randomIndex = random.Next(0, alinti.Length);
            string randomalinti = alinti[randomIndex];

            richTextBox1.Text = randomalinti;

        }
    }
}
