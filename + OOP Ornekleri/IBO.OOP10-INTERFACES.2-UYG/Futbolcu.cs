using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP10_INTERFACES._2_UYG
{
   public class IFutbolcu
    {
        public IFutbolcu()
        {
        }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public float Boyu { get; set; }
        public float Kilo { get; set; }
        public int FormaNumamrasi { get; set; }
        public string Takimi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int BacakKasIndexi { get; set; }

        public int Yas
        {
            get
            {
                int yas = DateTime.Now.Year - DogumTarihi.Year;
                return yas;
            }
        }
        public   int SutGucu ()
        {
           return BacakKasIndexi * 4;
            
        }
        public override string ToString()
        {
            return this.Adi +" "+ this.Soyadi +" "+ this.FormaNumamrasi;
        }
    }
}
