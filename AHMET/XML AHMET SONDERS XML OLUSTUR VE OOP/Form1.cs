using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_AHMET_SONDERS_XML_OLUSTUR_VE_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("xmlim.xml");
            XmlNode ogrenciler = xdoc.SelectSingleNode("Ogrenciler");
            XmlNodeList ogrenci = ogrenciler.SelectNodes("Ogrenci");
            listBox1.Items.Clear();
            foreach (XmlNode ogr in ogrenci)
            {
                Ogrenci o1 = new Ogrenci();
                o1.Adi = ogr.Attributes["Adi"].Value;
                o1.Soyadi = ogr.Attributes["Soyadi"].Value;
                o1.Node = ogr;
                listBox1.Items.Add(o1);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            listBox2.Items.Clear();
            Ogrenci secili =(Ogrenci)listBox1.SelectedItem;
            foreach (XmlNode ders in secili.Node.SelectNodes("Ders"))
            {
                Ders d = new Ders();
                d.Node = ders;
                listBox2.Items.Add(d);

            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null) return;

            Ders seciliders = (Ders)listBox2.SelectedItem;

            listBox3.Items.Clear();
            foreach (XmlNode sinav in seciliders.Node.SelectNodes("Sinavlar/Sinav")) 
            {
                Sinav s = new Sinav();
                s.Node = sinav;
                listBox3.Items.Add(s);
            }
            foreach (XmlNode projeler in seciliders.Node.SelectNodes("Projeler/Proje"))
                {
                Proje p = new Proje();
                p.Adi = projeler.Attributes["Adi"].Value;
                p.Degeri = Convert.ToInt32(projeler.FirstChild.Value);
                listBox4.Items.Add(p);
            
                 }
        }
    }
}
