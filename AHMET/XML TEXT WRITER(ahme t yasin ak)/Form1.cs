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

namespace XML_TEXT_WRITER_ahme_t_yasin_ak_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader xreader = new XmlTextReader("..\\..\\kg.xml");
            
            while(xreader.Read())
            {
                if (xreader.NodeType == XmlNodeType.Element && xreader.Name == "Ogrenci") ;


                listBox1.Items.Add(xreader.Value);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("http://www.internethaber.com/rss");
            while(reader.Read())
            {
                listBox1.Items.Add(reader.Value);
            }
        }
    }
}
