/*
 * Erste Gehversuche mit C# Klassen
 * 11.05.2018
 * (c) M. Gehrig
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKW_20190511
{
    // Hier baue ich meine PKW-Klasse
    class PKW
    {
        /// <summary>
        /// Länge des Autos
        /// </summary>
        double laenge;

        /// <summary>
        /// Gewicht des Autos
        /// </summary>
        int gewicht = 0;

        /// <summary>
        /// Anzahl Sitze des Autos
        /// </summary>
        int anzahl_sitze = 4;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="t_leange">Länge des Autos</param>
        /// <param name="t_gewicht">Gewicht des Autos</param>
        /// <param name="t_sitze">Anzahl Sitze des Autos</param>
        public PKW(double t_leange, int t_gewicht, int t_sitze)
        {
            gewicht         = t_gewicht;
            laenge          = t_leange;
            anzahl_sitze    = t_sitze;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Beschleunigen()
        {

        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiieren Autos
            // Auto BMW
            PKW myBMW = new PKW(5.20, 700, 5);
        }
    }
}
