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
using System.Data.SqlClient;


namespace XML_VERI_OKUYAK_KENDIM_YAZIM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DATA yeni = new DATA();
            if(yeni.baglan.State==System.Data.ConnectionState.Open)
            {
                yeni.baglan.Close();
            }
          
                yeni.baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Bilgiler", yeni.baglan);
                SqlDataReader dr = komut.ExecuteReader();
                XmlDocument xdoc = new XmlDocument();

            XmlElement kullanicilar = xdoc.CreateElement("kullanıcılar");
            kullanicilar.SetAttribute("ID", "1");
            int k = 1;
            while(dr.Read())
            {
                XmlElement kulanici = xdoc.CreateElement("kullanici");
                XmlElement kullanıcıadı = xdoc.CreateElement("kullaniciadi");
                kullanıcıadı.InnerText = dr[0].ToString();
                XmlElement sifre = xdoc.CreateElement("sifre");
                sifre.InnerText = dr[1].ToString();
                XmlElement adi = xdoc.CreateElement("adi");
                adi.InnerText = dr[2].ToString();
                XmlElement soyadi = xdoc.CreateElement("soyadi");
                soyadi.InnerText = dr[3].ToString();

                //XmlAttribute xml = xdoc.CreateAttribute("ID");
                //xml.Value = k.ToString();
                //kulanici.Attributes.Append(xml);
                kulanici.SetAttribute("ID", k.ToString());

                kulanici.AppendChild(kullanıcıadı);
                kulanici.AppendChild(sifre);
                kulanici.AppendChild(adi);
                kulanici.AppendChild(soyadi);
                kullanicilar.AppendChild(kulanici);
                k++;

            }


            xdoc.AppendChild(kullanicilar);

            xdoc.Save("idsssleee.xml");

            //}
            //catch
            //{

            //    MessageBox.Show("Hata var");
            //}
            //finally
            //{
            //    yeni.baglan.Close();
            //}


        }
    }
}
