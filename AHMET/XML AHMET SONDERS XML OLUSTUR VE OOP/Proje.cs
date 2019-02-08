using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_AHMET_SONDERS_XML_OLUSTUR_VE_OOP
{
    class Proje
    {
        public string Adi { get; set; }
        public int Degeri { get; set; }
      

        public override string ToString()
        {
            return this.Adi + " " + this.Degeri;
        }
    }
}
