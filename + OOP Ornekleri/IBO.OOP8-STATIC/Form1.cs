using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBO.OOP8_STATIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sa= "Merhaba";
            Yazdır.Yazsın(sa);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogrenci.OgrenciSayisi = 4;
            Ogrenci og1 = new Ogrenci();
            Ogrenci og2 = new Ogrenci();
            Ogrenci og3 = new Ogrenci();
            MessageBox.Show(Ogrenci.OgrenciSayisi.ToString());





        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
