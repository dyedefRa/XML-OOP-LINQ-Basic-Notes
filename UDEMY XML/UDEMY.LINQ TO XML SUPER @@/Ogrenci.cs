using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çalışmam6
{
    class Ogrenci
    {
        public Guid ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Numarasi { get; set; }
        public override string ToString()
        {
            return this.Adi + " " + this.Soyadi;
        }
    }
    
}
