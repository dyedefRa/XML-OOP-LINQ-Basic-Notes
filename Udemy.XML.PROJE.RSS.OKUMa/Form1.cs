using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Udemy.XML.PROJE.RSS.OKUMa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlCevir();


            foreach (Haber haber in gelenler)
            {
                listBox1.Items.Add(haber);
            }
            

        }


        List<Haber> gelenler = new List<Haber>();
        private List<Haber> XmlCevir()
        {
            XDocument xdoc = XDocument.Load(textBox1.Text);
            List<XElement> veriler = new List<XElement>();
            veriler= xdoc.Descendants("item").ToList();

           
            foreach (XElement item in veriler)
            {
                Haber temp = new Haber();
                temp.Baslik = item.Element("title").Value;
                temp.Aciklama = item.Element("description").Value;
                temp.Link = item.Element("link").Value;

                gelenler.Add(temp);

            }
            return gelenler;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox secilendeger = (ListBox)sender;
              Haber gelenhaber=(Haber) secilendeger.SelectedItem;
            webBrowser1.DocumentText = gelenhaber.Aciklama;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
