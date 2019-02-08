using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP5_Polymorphism_virtual_override
{
    class Yemek
    {
        public string PisirmeSuresi  { get; set; }
        public string Malzemeler { get; set; }
        public int KaloriDegeri { get; set; }
        public string AciTipi { get; set; }
        public string Asci { get; set; }
        public string PismeSekli { get; set; }
        public string PismeYeri { get; set; }
        public bool TuzVarYok { get; set; }
        public bool ExtraVarYok { get; set; }


        public virtual string SunumSekli ()
        {
            return $"  Yanında az pilav ve salata ile";
        }
    }
}
