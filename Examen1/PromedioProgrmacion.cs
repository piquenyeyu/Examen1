using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public  class PromedioProgrmacion : promedio
    {
        public double Calcularpromedio()
        {
            double promo = (NOTA1 + NOTA2 + NOTA3 +ACTITUDINAL)/4;
            return promo;
        }
    }
}
