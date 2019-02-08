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

namespace XML_VERI_OKUYAK_KENDIM_YAZIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //XML OKUDUK
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("..\\..\\..\\..\\..\\Desktop\\GARDAS.xml");
            XmlNode enust = xdoc.SelectSingleNode("buenbabaları");
            XmlNodeList sınıf = enust.SelectNodes("sınıf");

           

            foreach (XmlNode enkucukchildlar in sınıf)
            {
                ListViewItem li = new ListViewItem();
                li.Text = enkucukchildlar.SelectSingleNode("tekhaneli").InnerText;
                li.SubItems.Add(enkucukchildlar.SelectSingleNode("ikihaneli").InnerText);
                li.SubItems.Add(enkucukchildlar.SelectSingleNode("Randomolan").InnerText);

                listView1.Items.Add(li);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ID YI EVENTTEN CEKICEZ
            XmlDocument docu = new XmlDocument();
            docu.Load("..\\..\\fistikcisahap.xml");


            XmlNode calisanlar = docu.SelectSingleNode("calisanlar");

            XmlNodeList personellerim = calisanlar.SelectNodes("personel");

            foreach (XmlNode item in personellerim)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.SelectSingleNode("ad").InnerText;
                li.SubItems.Add(item.SelectSingleNode("soyad").InnerText);
                li.SubItems.Add(item.SelectSingleNode("cinsiyet").InnerText);
                li.SubItems.Add(item.SelectSingleNode("pozisyon").InnerText);

                listView2.Items.Add(li);

            }


           
        }
    }
}
