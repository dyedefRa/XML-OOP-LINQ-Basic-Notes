using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace XML_AHMET_SONDERS_XML_OLUSTUR_VE_OOP
{
    class Sinav
    {
        public string Adi { get { return this.Node.Attributes["Adi"].Value; } }
        public double Not { get
            {if(Node.FirstChild!=null)
            return   Convert.ToDouble(this.Node.FirstChild.Value);
                return 0;
            } }
        public XmlNode Node { get; set; }

        public override string ToString()
        {
            return this.Adi + " " + this.Not;
        }
    }
}
