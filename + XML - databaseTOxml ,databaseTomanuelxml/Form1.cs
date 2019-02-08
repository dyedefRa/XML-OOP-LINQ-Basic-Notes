using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace çalışma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=BAKIOZTURK\SQLSERVER;Initial Catalog=silebilirsin;MultipleActiveResultSets=true;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {//DATABASEDEN ALIP DIREK DATAGRIDVIEW VERDI
            SqlDataAdapter da = new SqlDataAdapter("Select * from bu2", baglan);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];

        
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Manuel yazmak
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from bu", baglan);
            SqlDataReader dr = komut.ExecuteReader();

            XmlDocument xdoc = new XmlDocument();

            XmlElement kitaplar = xdoc.CreateElement("kitaplarim");
           

            while (dr.Read())
            {
                XmlElement kitap = xdoc.CreateElement("kitap");

                XmlElement KitapNo = xdoc.CreateElement("KitapNo");
                KitapNo.InnerText = dr[0].ToString();

                XmlElement KitapAd = xdoc.CreateElement("KitapAd");
                KitapAd.InnerText = dr[1].ToString();

                XmlElement KitapYazar = xdoc.CreateElement("KitapYazar");
                KitapYazar.InnerText = dr["KitapYazar"].ToString();

                XmlElement KitapSayfa = xdoc.CreateElement("KitapSayfa");
                KitapSayfa.InnerText = dr[3].ToString();

                SqlCommand komut2 = new SqlCommand("select KitapTur,KitapRenk from bu2 where kitapadi=@k1", baglan);
                komut2.Parameters.AddWithValue("@k1", dr["KitapAd"].ToString());
                SqlDataReader drr = komut2.ExecuteReader();

               if(drr.Read())
                {
                    XmlAttribute kitaptur = xdoc.CreateAttribute("KitapTürü");
                    kitaptur.Value = drr[0].ToString();
                    XmlAttribute kitaprenk = xdoc.CreateAttribute("KitapRengi");
                    kitaprenk.Value = drr[1].ToString();
                    KitapAd.Attributes.Append(kitaptur);
                    KitapAd.Attributes.Append(kitaprenk);
                }
                kitap.AppendChild(KitapNo);
                kitap.AppendChild(KitapAd);
                kitap.AppendChild(KitapYazar);
                kitap.AppendChild(KitapSayfa);
                kitaplar.AppendChild(kitap);
                komut2.Dispose();

            }
            baglan.Close();
            komut.Dispose();
            
            xdoc.AppendChild(kitaplar);
            xdoc.Save("oldumu.xml");

        }

        private void button2_Click_1(object sender, EventArgs e)
        { //DATABASEDEN ALDI VERILERI XML OLARAK YAZDI
            SqlDataAdapter da = new SqlDataAdapter("Select * from bu",baglan);
            DataTable ds = new DataTable("kitaplarım");
            da.Fill(ds);
            ds.WriteXml("saaa.xml");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("saaa.xml");
            dataGridView2.DataSource = ds.Tables[0];
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "KitapNo";
        }
    }
}
