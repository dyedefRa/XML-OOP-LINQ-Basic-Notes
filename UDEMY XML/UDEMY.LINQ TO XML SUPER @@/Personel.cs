using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çalışmam6
{
    class Personel
    {
        public int ID { get; set; }
        public string Adi { get; set; }
      

        public override string ToString()
        {
            return this.ID + " " + this.Adi;
        }

    }
}
