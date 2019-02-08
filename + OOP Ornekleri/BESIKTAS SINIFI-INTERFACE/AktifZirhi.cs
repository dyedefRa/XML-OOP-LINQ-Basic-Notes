using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BESIKTAS_SINIFI_INTERFACE
{
    class AktifZirhi : ZIRH,IFazladanSavunmaYapabilir,IYansıtabilir
    {
        public override string Leveli { get => "36 Level"; }
        public override ZirhinOzelligi ZirhEkOzelligi { get => ZirhinOzelligi.Savunma; }

        public override int SavunmaDegeri => 5;

        public string ToplamSavunmaDegeri;
        public int ToplamSAvunmaSayısı;
       
        public int FazladanSavun(int SavunmamDegeri)
        {
            ToplamSAvunmaSayısı = this.SavunmaDegeri + SavunmamDegeri;
            return ToplamSAvunmaSayısı;
        }

        public string YansıtmaDegeri(int bueklensin)
        {
            ToplamSavunmaDegeri= $"{bueklensin} Savunması var";
            return ToplamSavunmaDegeri;
        }
        public override string ToString()
        {
            return $"Toplam ={ToplamSavunmaDegeri} , kaç ıle savunyor ={ToplamSAvunmaSayısı}";
        }
    }
}
