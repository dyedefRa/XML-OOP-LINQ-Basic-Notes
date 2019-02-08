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
using System.Xml.Linq;

namespace çalışmam6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrencim = new List<Ogrenci>();
            for (int i = 0; i < 50; i++)
            {
                Ogrenci o1 = new Ogrenci();
                o1.ID = Guid.NewGuid();
                o1.Adi = FakeData.NameData.GetFirstName();
                o1.Soyadi = FakeData.NameData.GetSurname();
                o1.Numarasi = FakeData.NumberData.GetNumber(1, 100);

                ogrencim.Add(o1);
            }

            //XDocument xd = new XDocument(new XDeclaration("ver 1.1", "UTF-8", "no"), new XElement("RandomOgrenciler", ogrencim.Select(I => new XElement("Ogrenci", new XElement("ID", I.ID), new XElement("Adi", I.Adi), new XElement("Soyadi", I.Soyadi), new XElement("Numarasi", I.Numarasi)))));
            //xd.Save("ff.xml");


            //---------------------------------------------------------------------


            //List<Ogrenci> gelecekler = new List<Ogrenci>();
            //XDocument doc = XDocument.Load("ff.xml");
            //List<XElement> ogrenciler=  doc.Descendants("Ogrenci").ToList();

            //foreach (XElement item in ogrenciler)
            //{
            //    Ogrenci temp = new Ogrenci();
            //    temp.ID = Guid.Parse(item.Element("ID").Value);
            //    temp.Adi = item.Element("Adi").Value();
            //    temp.Soyadi = item.Element("Soyadi").Value();
            //    temp.Numarasi = Convert.ToInt32(item.Element("Numarasi").Value);

            //    gelecekler.Add(temp);
            //}

            //foreach (Ogrenci ogr in gelecekler)
            //{

            //    listBox1.Items.Add(ogr);
            //}


            //----------------------------------
            //XDocument xdoc = new XDocument(new XDeclaration("ver 1.1", "utf-8", "yes"), new XElement("Ogrenciler", ogrencim.Select(I => new XElement("Ogrenci", new XElement("ID", I.ID), new XElement("Adi", I.Adi), new XElement("Soyadi", I.Soyadi), new XElement("Numarasi", I.Numarasi)))));

            //xdoc.Save("yow.xml");


            List<Ogrenci> gelenler = new List<Ogrenci>();
            XDocument xxdox = XDocument.Load("yow.xml");
            List<XElement> ogrenji = xxdox.Descendants("Ogrenci").ToList();

            foreach (XElement ogrenciler in ogrenji)
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.ID = Guid.Parse(ogrenciler.Element("ID").Value);
                ogrenci.Adi = ogrenciler.Element("Adi").Value;
                ogrenci.Soyadi = ogrenciler.Element("Soyadi").Value;
                ogrenci.Numarasi = Convert.ToInt32(ogrenciler.Element("Numarasi").Value);

                gelenler.Add(ogrenci);

            }

            foreach (Ogrenci item in gelenler)
            {
                listBox1.Items.Add(item);
            }
            
        }

    }
}
