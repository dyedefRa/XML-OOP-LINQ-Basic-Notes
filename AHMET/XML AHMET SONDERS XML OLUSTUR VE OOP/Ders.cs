using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace XML_AHMET_SONDERS_XML_OLUSTUR_VE_OOP
{
    class Ders
    {
        public string Adi
        {
            get
            { return this.Node.Attributes["Adi"].Value; }
        }
        public double Kredi
        {
            get
            { return Convert.ToDouble(this.Node.Attributes["Kredi"].Value); }
        }
        public int DersSaati { get { return Convert.ToInt32(Node.Attributes["DersSaati"].Value); } }

        public XmlNode Node { get; set; }
        public override string ToString()
        {
            return this.Adi + " " + this.Kredi + " " + this.DersSaati;
        }
    }
}
