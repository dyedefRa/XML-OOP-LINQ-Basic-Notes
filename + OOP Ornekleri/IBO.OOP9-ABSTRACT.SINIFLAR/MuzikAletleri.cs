using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP9_ABSTRACT.SINIFLAR
{
   abstract class MuzikAletleri
    {
        // ABSTRACT SINIFLAR MIRAS VERMEKICIN OLUSTURULUR .

        public abstract string Cal();
        // public abstract CalmaTuru Calmaturl { get; set; }

        public abstract CalmaTuru Turu { get; }
    }
}
