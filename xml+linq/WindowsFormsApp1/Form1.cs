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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=BAKIOZTURK\SQLSERVER;Initial Catalog=silebilirsin;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {


            //XmlDocument xdoc = new XmlDocument();
            //SqlDataAdapter da = new SqlDataAdapter("Select * from bu", baglan);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //ds.WriteXml("D://sasa.xml");

            //---------------------------------------------------

            // DataSet ds = new DataSet();
            //ds.ReadXml("D://sasa.xml");
            // dataGridView1.DataSource = ds.Tables[0];

            //---------------------------------------------------


            //if (baglan.State!=ConnectionState.Open)
            //{
            //    baglan.Open();
            //}
            //SqlCommand komut = new SqlCommand("Select * from bu", baglan);
            //SqlDataReader dr = komut.ExecuteReader();
            //XmlDocument xdoc = new XmlDocument();
            //XmlElement kitaplar = xdoc.CreateElement("Kitaplar");
            //int k = 1;
            //while (dr.Read())
            //{
            //    XmlElement kitap = xdoc.CreateElement("Kitap");
            //    XmlAttribute id = xdoc.CreateAttribute("ID");
            //    id.Value = k.ToString();
            //    kitap.Attributes.Append(id);

            //    XmlElement adi = xdoc.CreateElement("KitapAdi");
            //    adi.InnerText = dr["KitapAd"].ToString();
            //    adi.SetAttribute("AttributeAdi", (k + 1).ToString());

            //    XmlElement yazar = xdoc.CreateElement("Yazari");
            //    yazar.InnerText = dr["KitapYazar"].ToString();

            //    XmlElement sayfa = xdoc.CreateElement("SayfaSayisi");
            //    sayfa.InnerText = dr["KitapSayfa"].ToString();

            //    kitap.AppendChild(adi);
            //    kitap.AppendChild(yazar);
            //    kitap.AppendChild(sayfa);

            //    kitaplar.AppendChild(kitap);


            //}
            //if(baglan.State!=ConnectionState.Closed)
            //{
            //    baglan.Close();
            //}
            //dr.Close();
            //xdoc.AppendChild(kitaplar);
            //xdoc.Save("asf.xml");


            //---------------------------------------------------


            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from bu", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            List<kitap> kitaplar = new List<kitap>();

            

            while(dr.Read())
            {
                kitap temp = new kitap();
                
                temp.KitapAd = dr["KitapAd"].ToString();
                temp.KitapYazar = dr["KitapYazar"].ToString();
                temp.KitapSayfa = Convert.ToInt32(dr["KitapSayfa"]);
                kitaplar.Add(temp);

            }
            XDocument xdoc = new XDocument(new XDeclaration("ver 1.1", "UTF-8", "yes"), new XElement("kitaplar", kitaplar.Select(I => new XElement("Kitap", new XElement("kitapad", I.KitapAd), new XElement("yazar", I.KitapYazar), new XElement("sayfa", I.KitapSayfa)))));
            xdoc.Save("D://buus.xml");
            baglan.Close();
        }
    }
}
