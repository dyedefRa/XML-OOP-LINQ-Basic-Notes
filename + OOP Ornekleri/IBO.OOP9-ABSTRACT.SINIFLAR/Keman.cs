using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP9_ABSTRACT.SINIFLAR
{
    class Keman:MuzikAletleri
    {
        public override CalmaTuru Turu => CalmaTuru.Telli;

        //public override CalmaTuru Calmatur {
        //    get
        //    {
        //        return CalmaTuru.Telli;
        //    }
        //    set => throw new NotImplementedException(); }

        public override string Cal()
        {
            return $"Keman Çalınıyor";
        }

     
    }
}
