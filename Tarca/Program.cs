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
        /// A pénztárcában lévő címletek darabszáma.
        /// </summary>
        int[] cimletek = new int[12];

        /// <summary>
        /// A címletek névértékei.
        /// </summary>
        int[] ertekek = new int[]
        {
            5,10,20,50,100,200,500,
            1000,2000,5000,10000,20000
        };

        /// <summary>
        /// A pénztárcában található pénzek összértéke.
        /// </summary>
        public int Osszeg
        {
            get
            {
                int osszeg = 0;
                for (int i = 0; i < cimletek.Length; i++)
                {
                    osszeg += ertekek[i] * cimletek[i];
                }
                return osszeg;
            }
        }

        public void Betesz(int darab, int cimlet)
        {
            cimletek[cimlet] += darab;
        }

        public void Betesz(int[] cimletek)
        {
            for (int i = 0; i < cimletek.Length; i++)
            {
                this.cimletek[i] += cimletek[i];
            }
        }

        public void Betesz(int osszeg)
        {

        }

        /// <summary>
        /// Kiveszi a pénztárcából a paraméterül adott összeget,
        /// ha lehetséges. Igazzal tér vissza, ha sikerült.
        /// </summary>
        /// <param name="penz">Kiveendő összeg.</param>
        /// <returns>A kivétel sikeressége.</returns>
        //public bool Kivesz(int penz)
        //{
        //    if (penz > osszeg)
        //        return false;
        //    osszeg -= penz;
        //    return true;
        //}

        /// <summary>
        /// Karakterlánccá alakítja az osztályt, ami tartalmazza
        /// a pénztárca aktuális összegét.
        /// </summary>
        /// <returns>Karakterlánc.</returns>
        public override string ToString()
        {
            return "A pénztárcában " + Osszeg + " forint van.";
        }

        class Program
        {
            static void Main(string[] args)
            {
                Pénztárca p1 = new Pénztárca();
                Pénztárca p2 = new Pénztárca();
                p1.Betesz(5, 11);
                p1.Betesz(new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1 });
                Console.WriteLine(p1);
                Console.ReadKey();
            }
        }
    }
}
