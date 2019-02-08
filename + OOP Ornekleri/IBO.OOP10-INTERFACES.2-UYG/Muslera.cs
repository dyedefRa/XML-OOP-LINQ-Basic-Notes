using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBO.OOP10_INTERFACES._2_UYG
{
     public class Muslera:IFutbolcu
    {
        public int EldivenNumarasi { get; set; }
        public bool KalecilerleAnalaşbilmeDurumu { get; set; }
        
    }
    enum Takimi
    {
        PSG=0,
        FCBARCA=1,
        REAL=2,
        TOTHENNAM=3,
        BESIKTAS=4,
    }
    
    
}
