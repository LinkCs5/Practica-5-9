using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_7.Domain
{
    internal class VerificadorPalindromo
    {
        public bool EsPalindromo(string Palabra)
        {
            Palabra = Palabra.Replace(" ", "").ToLower();
            int longitud = Palabra.Length;
            for(int i = 0; i < longitud / 2; i++) 
            {
                if (Palabra[i] != Palabra[longitud+ - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
