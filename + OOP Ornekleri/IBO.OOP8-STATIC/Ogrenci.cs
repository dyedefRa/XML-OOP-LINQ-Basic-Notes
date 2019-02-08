using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP8_STATIC
{
    class Ogrenci
    {
        public Ogrenci()
        {
            OgrenciSayisi++;
        }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public int No { get; set; }
        //Amacım Kaç ogrenci oluştutursam oluşturayım o sayıya ulasmak.
        // eger ben public int OgrenciSayisi { get; set; } deseydim
        // ve ctorun ıcınde buna ++ deseydım
        //her oluştudugum ogrencı ııcn bu bır property olcaktı 
        //uzerıne bısey ekleyemezıdım
        // bu yuzden bu Ogrencısayısızımbırtısını
        //STATIC TANIMLAMAM GEREK
        public static int OgrenciSayisi { get; set; }
        //BUNA NORMAL SARTLARDA ERISEMEM
        //TAKI Ogrenci.OgrenciSayisi diyene kadar..

       

    }
}
