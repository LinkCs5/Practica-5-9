using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Domain
{
    internal class ClasificadorPalabras
    {
        private Dictionary<char, List<Palabra>> palabrasClasificadas = new Dictionary<char, List<Palabra>>();

        public void AgregarPalabra (string Texto)
        {
            char primeraLetra = Texto[0];
            if(!palabrasClasificadas.ContainsKey(primeraLetra))
            {
                palabrasClasificadas[primeraLetra] = new List<Palabra>();

            }
            palabrasClasificadas[primeraLetra].Add(new Palabra(Texto));
        }

        public List<char> OtenerLetrasClasificadas()
        {
            return palabrasClasificadas.Keys.ToList();
        }

        public List<string> ObtenerPalabrasPorLetras( char Letra)
        {
            return palabrasClasificadas.ContainsKey(Letra) ? palabrasClasificadas[Letra].Select(p => p.Texto).ToList() : new List<string>();
        }
    }
}
