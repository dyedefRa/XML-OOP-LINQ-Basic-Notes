using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP5.Polymorphism_devamı
{
    class Sepet
    {
        public decimal ToplamFiyat { get; set; }

       public void UrunEkle(Urun urunum)
        {
            ToplamFiyat += urunum.KdvliFiyatHesapla();
        }
    }
}
