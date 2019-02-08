using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP5.Polymorphism_devamı
{
    class TekstilUrunu:Urun
    {
        public string KumasTuru { get; set; }
        public string Renk { get; set; }
        public string KumasKalite { get; set; }
        public override decimal KdvliFiyatHesapla()
        {
            return Fiyat + (Fiyat * 0.8m);

        }
    }
}
