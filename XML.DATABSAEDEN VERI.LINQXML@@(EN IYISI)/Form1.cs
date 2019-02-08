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
using System.Xml.Linq;

namespace XML.DATABSAEDEN_VERI.LINQXML__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DATA datam = new DATA();

        private void button1_Click(object sender, EventArgs e)
        {
            //ONCE XMLWRITER KULLANALIM

            //SqlDataAdapter da = new SqlDataAdapter("Select * from bu", datam.baglan);
            //DataSet ds = new DataSet();

            //da.Fill(ds);
            //ds.WriteXml("WriteXml.xml");

            //-----------------------------------

            //şimdi ReadXml kullanalım

            //DataSet ds = new DataSet();
            //ds.ReadXml("WriteXml.xml");
            //dataGridView1.DataSource = ds.Tables[0];

            //-----------------------------------

            //SYSTEM.XML ILE YAZALIM  

            //if (datam.baglan.State!=ConnectionState.Open)
            // {
            //     datam.baglan.Open();
            // }

            // SqlCommand komut = new SqlCommand("Select *  from bu", datam.baglan);
            // SqlDataReader dr = komut.ExecuteReader();

            // XmlDocument xdoc = new XmlDocument();
            // XmlElement kitaplar = xdoc.CreateElement("Kitaplar");

            // int k = 1;
            // while(dr.Read())
            // {
            //     XmlElement kitap = xdoc.CreateElement("Kitap");

            //     XmlAttribute id = xdoc.CreateAttribute("ID");
            //     id.Value = k.ToString();

            //     kitap.Attributes.Append(id);

            //     XmlElement adi = xdoc.CreateElement("KitapAdi");
            //     adi.InnerText = dr["KitapAd"].ToString();

            //     adi.SetAttribute("AD", (k + 1).ToString());
            //     XmlElement yazar = xdoc.CreateElement("Yazari");
            //     yazar.InnerText = dr["KitapYazar"].ToString();

            //     XmlElement sayfa = xdoc.CreateElement("SayfaSayisi");
            //     sayfa.InnerText = dr["KitapSayfa"].ToString();



            //     kitap.AppendChild(adi);
            //     kitap.AppendChild(yazar);
            //     kitap.AppendChild(sayfa);

            //     kitaplar.AppendChild(kitap);
            //     k++;

            // }

            // xdoc.AppendChild(kitaplar);

            // dr.Close();
            // datam.baglan.Close();
            // xdoc.Save("XmlDocument.xml");


            //-----------------------------------

            //BUNU BIDE OKUYALIM
            //KITAP  CLASSI KURUYORUM


            //    XmlDocument xdoc = new XmlDocument();
            //    xdoc.Load("XmlDocument.xml");

            //    XmlNode kitaplar = xdoc.SelectSingleNode("Kitaplar");

            //    XmlNodeList kitaps = kitaplar.SelectNodes("Kitap");

            //    //List<KITAP> a atıp ordan foreachile listiviewe yazdırcam

            //    List<KITAP> kitaplistem = new List<KITAP>();

            //    foreach (XmlNode kitap in kitaps)
            //    {
            //        KITAP temp = new KITAP();

            //        temp.ID = Convert.ToInt32(kitap.Attributes["ID"].Value);
            //        temp.Adi=  kitap.SelectSingleNode("KitapAdi").InnerText;
            //        temp.Atributes2 = Convert.ToInt32(kitap.SelectSingleNode("KitapAdi").Attributes["AD"].Value);
            //        temp.Yazari = kitap.SelectSingleNode("Yazari").InnerText;
            //        temp.SayfaSayisi = Convert.ToInt32(kitap.SelectSingleNode("SayfaSayisi").InnerText);

            //        kitaplistem.Add(temp);

            //    }


            //    //YAZDIRMA ISLEMINI BURDA YAPCAM LISTIN ICINE GIRIYORUM

            //    foreach (KITAP kitabim in kitaplistem)
            //    {
            //        //BURDA OVERRIDE ETMEM GEREKTIGININ FARKINA VARDIM

            //        ListViewItem li = new ListViewItem();
            //        li.Text = kitabim.Adi;
            //        li.SubItems.Add(kitabim.Yazari);
            //        li.SubItems.Add(kitabim.SayfaSayisi.ToString());
            //        li.Tag = kitabim;
            //        listView1.Items.Add(li);

            //    }


            //    //LIST VIEW ATTIGIMDA ATRIBUTELERI CEKEMEDIM. CUNKU LIST WIEVE KITAP NESNESI OLARAK ATAMADIM. SIMDI listbox ILE DENICEM


            //    foreach (KITAP item in kitaplistem)
            //    {

            //        listBox1.Items.Add(item);


            //    }

            //------------------------------------------------------------------------------------------------

            //SIMDI SYSTEM.XML.LINQ YAPALIM :DDDDDDDDDDD
            // ONCE YAZALIM DATABASEDEN CEKCEM


            //if(datam.baglan.State!=ConnectionState.Open)
            //{
            //    datam.baglan.Open();
            //}

            //SqlCommand komut = new SqlCommand("Select * from bu", datam.baglan);
            //SqlDataReader dr = komut.ExecuteReader();

            //List<KITAP> kitaplarim = new List<KITAP>();
            //int k = 1;
            //while(dr.Read())
            //{
            //    KITAP temp = new KITAP();
            //    temp.ID =k;
            //    temp.Adi = dr["KitapAd"].ToString();
            //    temp.Atributes2 = k + 1;
            //    temp.Yazari = dr["KitapYazar"].ToString();
            //    temp.SayfaSayisi = int.Parse(dr["KitapSayfa"].ToString());
            //    kitaplarim.Add(temp);
            //    k++;
            //}

            //XDocument xdoc = new XDocument(new XDeclaration("1.1", "UTF-8", "yes"), new XElement("Kitaplar", kitaplarim.Select(I => new XElement("Kitap", new XAttribute("ID", I.ID), new XElement("KitapAdi", I.Adi, new XAttribute("AD", I.Atributes2)), new XElement("Yazari", I.Yazari), new XElement("SayfaSayisi", I.SayfaSayisi)))));

            //xdoc.Save("XmlLinq.xml");

            //TEKTEK YAZDIK SUPERIZ :D

            //------------------------------------------------------------------------------------------------

            //SIMDI BUNU OKUYALIM

            List<XElement> kitaps = new List<XElement>();

            XDocument xdoc = XDocument.Load("XmlLinq.xml");
            kitaps= xdoc.Descendants("Kitap").ToList();

            List<KITAP> kitaplistem = new List<KITAP>();
            foreach (XElement item in kitaps)
            {
                KITAP temp = new KITAP();
                temp.ID = Convert.ToInt32(item.Attribute("ID").Value);
                temp.Adi = item.Element("KitapAdi").Value;
                temp.Atributes2 = Convert.ToInt32(item.Element("KitapAdi").Attribute("AD").Value);
                temp.Yazari = item.Element("Yazari").Value;
                temp.SayfaSayisi = Convert.ToInt32(item.Element("SayfaSayisi").Value);

                kitaplistem.Add(temp);

            }

            //FOREACH ILE KITAPLISTEMI GEZIP LISTBOXA ATAYIM ZATEN HAZIR.

            foreach (KITAP item in kitaplistem)
            {
                listBox1.Items.Add(item);
            }
           




        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //YAPAMADIM BURAYI AMACIM listviewe classımdan nesne atıp sadece listviewde olanları degıldle clasa attıklarımıda cekmektı.
            if (listView1.SelectedItems.Count > 0)
            {
                textBox3.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox6.Text = listView1.SelectedItems[0].SubItems[2].Text;
               //ATTRIBUTELERI CEKEMEDIM....
               //DATA GRID VIEW ILE DENICEM YUKARIDA

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count>0)
            {
                KITAP k1 = (KITAP)listBox1.SelectedItem;

                textBox2.Text = k1.ID.ToString();
                textBox3.Text = k1.Adi;
                textBox4.Text = k1.Atributes2.ToString();
                textBox5.Text = k1.Yazari;
                textBox6.Text = k1.SayfaSayisi.ToString();
            }
        }
    }
}
