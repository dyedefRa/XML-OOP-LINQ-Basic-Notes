using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP10_INTERFACES_ARAYUZ_
{
    class Oyuncu
    {
        public string Adi { get; set; }
        public int Yasi { get; set; }
        public int YasamDegeri { get; set; }

        public Silah Silahi { get; set; }
         //WUD 52:20
        public void NisanAl()
        {if(Silahi is IYakinlastirilabilir)
            {
                IYakinlastirilabilir iy = (IYakinlastirilabilir)Silahi;
                iy.Yakınlastır();
            }
        }

        public void Saldir()
        {

        }
    }
}
