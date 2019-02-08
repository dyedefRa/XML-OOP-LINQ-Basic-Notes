using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP9_ABSTRACT.SINIFLAR
{
    class Bateri:MuzikAletleri
    {
        public override CalmaTuru Turu => CalmaTuru.Vurmalı;

        public override string Cal()
        {
            return $"Batari Çalınıyor";
        }

      
    }
}
