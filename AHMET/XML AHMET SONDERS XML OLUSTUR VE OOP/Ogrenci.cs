using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_AHMET_SONDERS_XML_OLUSTUR_VE_OOP
{
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public XmlNode Node { get; set; }


        public override string ToString()
        {
            return this.Adi + " " + this.Soyadi;
        }
    }
}
