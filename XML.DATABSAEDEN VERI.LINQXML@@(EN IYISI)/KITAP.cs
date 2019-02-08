using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML.DATABSAEDEN_VERI.LINQXML__
{
    class KITAP
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public int Atributes2 { get; set; }
        public string Yazari { get; set; }
        public int SayfaSayisi { get; set; }
        public override string ToString()
        {
            return this.Adi + "  " + this.Yazari;
        }
    }
}
