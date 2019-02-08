using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP5.Polymorphism_devamı
{
    class Ekmek:Urun
    {
        public double Gramaj { get; set; }
        public int MyProperty { get; set; }
        public override decimal KdvliFiyatHesapla()
        {
            return Fiyat + (Fiyat * 0.1m);
        }
    }
}
