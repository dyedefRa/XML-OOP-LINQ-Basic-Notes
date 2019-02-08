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

namespace XMLTEXTWRITER.VERITABNI.XMLOLUSTURALIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //KENDIM YAZDIM :P AHMET YASIN SON 3.DERS
        private void button1_Click(object sender, EventArgs e)
        {//TEK TEK YAZIYORUZ OLAYI xwriter.WriteStartElement("ISIM");
            //xwriter.WriteValue(OBJEECTDEGER);
            //OBJECt DEGERI DATA BASEDEN CEKIYORUZ dr[0].ToString();
            //Sonra xwriter.WriteEndElement();

            //EN SONUNDA xwriter.CLOSE() OR . FLUSH() !!!!!!
            XmlTextWriter xwriter = new XmlTextWriter("Categoriess.xml", Encoding.Unicode);
           
            SqlConnection baglan = new SqlConnection(@"Data Source=BAKIOZTURK\SQLSERVER;Initial Catalog=Kullanıcı;Integrated Security=True");

            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Bilgiler", baglan);
            SqlDataReader dr = komut.ExecuteReader();

            xwriter.WriteStartElement("Kütüphane");


            while(dr.Read())
            {
                xwriter.WriteStartElement("bilgiler");
                xwriter.WriteStartElement("kAdi");
                xwriter.WriteValue(dr[0].ToString());
                xwriter.WriteEndElement();

                xwriter.WriteStartElement("Sifre");
                xwriter.WriteValue(dr[1].ToString());
                xwriter.WriteEndElement();

                xwriter.WriteStartElement("Ad");
                xwriter.WriteValue(dr[2].ToString());
                xwriter.WriteEndElement();

                xwriter.WriteStartElement("Soyad");
                xwriter.WriteValue(dr[3].ToString());
                xwriter.WriteEndElement();

                xwriter.WriteEndElement();
            }
            xwriter.WriteEndElement();
            xwriter.Close();
            komut.Dispose();
            baglan.Close();
        }
    }
}
