using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBO.OOP5.Polymorphism_devamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepet ss = new Sepet();
            Ekmek ekmekim = new Ekmek();
            ekmekim.Gramaj = 14124;
            ekmekim.Fiyat = 0.75m;

            ss.UrunEkle(ekmekim);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TekstilUrunu ss = new TekstilUrunu();
            ss.Fiyat = 10;
            ss.Adet = 25;
            ss.Renk = "Red";
            Sepet sss = new Sepet();
            sss.UrunEkle(ss);
        }
    }
}
