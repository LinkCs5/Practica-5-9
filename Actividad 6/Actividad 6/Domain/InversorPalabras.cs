using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6.Domain
{
    internal class InversorPalabras
    {
        public string Invertir (string palabra)
        {
            char[] caractares = palabra.ToCharArray ();
            Array.Reverse (caractares);
            return new string (caractares);


        }
    }
}
