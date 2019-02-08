using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP10_INTERFACES_ARAYUZ_
{
    class Kanas : AtesliSilahlar, IYakinlastirilabilir
    {
        public string Yakınlastır()
        {
            return "yakınlastırıldı.";
        }
    }
}
