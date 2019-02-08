using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BESIKTAS_SINIFI_INTERFACE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        Random rand = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            AktifZirhi sa = new AktifZirhi();
            sa.GucDegeri = 32;
            sa.YansıtmaDegeri(33);
           
           
           int fazladansavunmadeger= sa.FazladanSavun(25);
            MessageBox.Show(" Burası Tostrıng ="+ sa.ToString() + " YANSITMADEGERI=  "+sa.YansıtmaDegeri(5) + " bura random= "+sa.FazladanSavun(rand.Next(1, 5)));

        }
    }
}
