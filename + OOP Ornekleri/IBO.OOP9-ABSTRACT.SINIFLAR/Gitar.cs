using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP9_ABSTRACT.SINIFLAR
{
    class Gitar:MuzikAletleri
    {
        public override CalmaTuru Turu => CalmaTuru.Telli;

        public override string Cal()
        {
            return $"Gitar Çalınıyor";
        }

      
    }
}
