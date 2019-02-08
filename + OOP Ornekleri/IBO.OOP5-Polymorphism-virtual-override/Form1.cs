using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBO.OOP5_Polymorphism_virtual_override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtYemekleri sa = new EtYemekleri();
            Yemeksunumsekli(sa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sa = new SebzeYemekleri();
            Yemeksunumsekli(sa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraSıcaklar ara = new AraSıcaklar();
            MessageBox.Show(ara.SunumSekli());
        }
        void Yemeksunumsekli(Yemek ymk)
        {
            MessageBox.Show(ymk.SunumSekli());
        }
    }
}
