using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarca
{
    /// <summary>
    /// <c>Pénztárca</c> osztály
    /// Egy pénztárca működését modellezi.
    /// </summary>
    class Pénztárca
    {
        /// <summary>
        /// A pénztárca értéke.
        /// </summary>
        int osszeg;

        /// <summary>
        /// Beteszi a pénztárcába a paraméterül adott összeget.
        /// </summary>
        /// <param name="penz">Beteendő összeg.</param>
        public void Betesz(int penz) { osszeg += penz; }

        /// <summary>
        /// Kiveszi a pénztárcából a paraméterül adott összeget,
        /// ha lehetséges. Igazzal tér vissza, ha sikerült.
        /// </summary>
        /// <param name="penz">Kiveendő összeg.</param>
        /// <returns>A kivétel sikeressége.</returns>
        public bool Kivesz(int penz)
        {
            if (penz > osszeg)
                return false;
            osszeg -= penz;
            return true;
        }

        /// <summary>
        /// Karakterlánccá alakítja az osztályt, ami tartalmazza
        /// a pénztárca aktuális összegét.
        /// </summary>
        /// <returns>Karakterlánc.</returns>
        public override string ToString()
        {
            return "A pénztárcában " + osszeg + " forint van.";
        }

        class Program
        {
            static void Main(string[] args)
            {
                Pénztárca p1 = new Pénztárca();
                Pénztárca p2 = new Pénztárca();
                p1.Betesz(50);
                p1.Kivesz(49);
                p1.Kivesz(20);
                Console.WriteLine(p1);
                Console.ReadKey();
            }
        }
    }
}
