using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1U2.Models
{
    public class Numeros
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public int Suma()
        {
            return Numero1 + Numero2;
        }
    }
}
