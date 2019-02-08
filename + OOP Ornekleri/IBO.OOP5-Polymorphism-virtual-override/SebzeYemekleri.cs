using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP5_Polymorphism_virtual_override
{
    class SebzeYemekleri:Yemek
    {
        public override string SunumSekli()
        {
            return "Yanında turşu , şalgam ile sunum yapılır...";
        }
    }
}
