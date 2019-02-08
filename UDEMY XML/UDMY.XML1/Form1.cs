using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UDMY.XML1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument dotxml = new XmlDocument();
            dotxml.Load("..\\..\\Urunler.xml");
            XmlNode urunler = dotxml.SelectSingleNode("urunler");
            textBox1.Text = urunler.Attributes["firma"].Value;
            textBox2.Text = urunler.Attributes["sube"].Value;


            foreach (XmlNode   urun in urunler.SelectNodes("urun"))
            {
                ListViewItem li = new ListViewItem();
                li.Text = urun.SelectSingleNode("adi").InnerText;
                li.SubItems.Add(urun.SelectSingleNode("fiyat").InnerText);
                li.SubItems.Add(urun.SelectSingleNode("adet").InnerText);
                listView1.Items.Add(li);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=BAKIOZTURK\SQLSERVER;Initial Catalog=Kitaplarim;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * from kitapBilgiler", baglan);
            baglan.Open();
            SqlDataReader dr = komut.ExecuteReader();



            XmlDocument doc = new XmlDocument();
            XmlElement urunler = doc.CreateElement("buenbabaları");
            urunler.SetAttribute("Şirket", "Bakiiii AS");
            urunler.SetAttribute("ADRES", "MERKEZ");
          
            doc.AppendChild(urunler);
            while(dr.Read())
            {
                XmlElement urun = doc.CreateElement("sınıf");
                XmlElement urunadı = doc.CreateElement("tekhaneli");
                urunadı.InnerText = dr[0].ToString();
                XmlElement urunfiyatı = doc.CreateElement("2haneli");
                urunfiyatı.InnerText = dr[1].ToString();
                XmlElement urunstokları = doc.CreateElement("Randomolan");
                urunstokları.InnerText = dr[2].ToString();
                urun.AppendChild(urunadı);
                urun.AppendChild(urunfiyatı);
                urun.AppendChild(urunstokları);

                urunler.AppendChild(urun);

            }
            komut.Dispose();
            baglan.Close();
            doc.Save("yeni.xml");
            






            //SqlCommand komut = new SqlCommand("Select * from kitapBilgiler", baglan);
            //baglan.Open();
            //SqlDataReader oku = komut.ExecuteReader();



            //XmlDocument doc = new XmlDocument();
            //XmlElement nodelerim = doc.CreateElement("bune");
            //doc.AppendChild(nodelerim);
            //while (oku.Read())
            //{
            //    XmlElement urun = doc.CreateElement("ıkincichild");
            //    XmlElement adi = doc.CreateElement("adi");
            //    adi.InnerText = oku[0].ToString();

            //    XmlElement fiyat = doc.CreateElement("fiyat");
            //    fiyat.InnerText = oku[1].ToString();

            //    XmlElement adet = doc.CreateElement("adet");
            //    adet.InnerText = oku[2].ToString();


            //    urun.AppendChild(adi);
            //    urun.AppendChild(fiyat);
            //    urun.AppendChild(adet);

            //    nodelerim.AppendChild(urun);

            //}
            //baglan.Close();
            //doc.Save("ilkXml.xml");
        }
    }
}
