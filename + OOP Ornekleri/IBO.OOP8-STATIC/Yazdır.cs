using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP8_STATIC
{
    static class Yazdır
    {


        public static  void Yazsın (string s)
        {
            System.Windows.Forms.MessageBox.Show(s);
        }
        public static  double KareAl(double s)
        {
            return Math.Pow(s, 2);
           
        }
        //EXTENSION HATIRLAYAK LA OLAY THIS INT  VE STATIKTE YAZCAZ.
        
        public static int Carpımları(this int SAYI,int ss)
        {
            return SAYI * ss;
        }
        
    }
}
