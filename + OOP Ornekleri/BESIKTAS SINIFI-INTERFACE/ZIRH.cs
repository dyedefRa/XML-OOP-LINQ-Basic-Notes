using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BESIKTAS_SINIFI_INTERFACE
{
    public abstract class ZIRH
    {
        public  abstract int SavunmaDegeri { get; }
        public int SaldiriDegeri { get; set; }
        public int ExpDegeri { get; set; }
        public int GucDegeri { get; set; }
        public int AlabilecegiTaslar { get; set; }
        public int ZirhinFiyati { get; set; }
        public abstract ZirhinOzelligi ZirhEkOzelligi { get;}
        public abstract string Leveli { get; }
        //ToyZirhi_18Lv,
        //AktifZirhi_36Lv,
        //c_48Lv,
        //YukselenMabedZirhi_64Lv,
        //YenilmezZirhi_76Lv,
        //SavasinGozdesiZirhi_88Lv,
        //AmonRaninZirhi_99Lv
       
    }
}
