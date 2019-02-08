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

namespace XML.RSS.OKUMA_ODEVI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { // YAPTIM LA :DDD
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("..\\..\\haber.xml");

            XmlNode rss = xdoc.SelectSingleNode("rss");
            XmlNode channel = rss.SelectSingleNode("channel");
            XmlNodeList listem = channel.SelectNodes("item");

            foreach (XmlNode item in listem)
            {
                XmlNode title = item.SelectSingleNode("title");
                listBox1.Items.Add(title.InnerText);
            }

        }
    }
}
