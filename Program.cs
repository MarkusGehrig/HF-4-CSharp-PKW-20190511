﻿/*
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
    abstract class Kraftfahrzeuge
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
        /// <param name="t_leange">Länge des Fahrzeuges</param>
        /// <param name="t_gewicht">Gewicht des Fahrzeuges</param>
        /// <param name="t_sitze">Anzahl Sitze des Fahrzeuges</param>
        public Kraftfahrzeuge(double t_leange, int t_gewicht, int t_sitze)
            :this(t_leange, t_gewicht)
        {
            Gewicht         = t_gewicht;
            Laenge          = t_leange;
            Anzahl_sitze    = t_sitze;
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="t_leange">Länge des Fahrzeuges</param>
        /// <param name="t_gewicht">Gewicht des Fahrzeuges</param>
        public Kraftfahrzeuge(double t_leange, int t_gewicht)
        {
            Gewicht = t_gewicht;
            Laenge = t_leange;
        }

        public double Laenge { get => laenge; set => laenge = value; }
        public int Gewicht { get => gewicht; set => gewicht = value; }
        public int Anzahl_sitze { get => anzahl_sitze; set => anzahl_sitze = value; }

        /// <summary>
        /// 
        /// </summary>
        public void Beschleunigen()
        {

        }
    }

    class PKW : Kraftfahrzeuge
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t_leange">Länge des PKW</param>
        /// <param name="t_gewicht">Gewicht des PKW</param>
        /// <param name="t_sitze">Anazhl Sitze des PKW</param>
        public PKW(double t_leange, int t_gewicht, int t_sitze)
            :base(t_leange, t_gewicht, t_sitze)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t_leange">Länge des PKW</param>
        /// <param name="t_gewicht">Gewicht des PKW</param>
        public PKW(double t_leange, int t_gewicht)
            : base(t_leange, t_gewicht)
        {

        }
    }

    class LKW : Kraftfahrzeuge
    {
        public LKW(double t_leange, int t_gewicht, int t_sitze)
            : base(t_leange, t_gewicht, t_sitze)
        {

        }

        public LKW(double t_leange, int t_gewicht)
            : base(t_leange, t_gewicht)
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
            Console.WriteLine("Gewicht:" + myBMW.Gewicht);

            myBMW.Gewicht = 750;
            Console.WriteLine("Gewicht:" + myBMW.Gewicht);

            PKW myMaserati = new PKW(6.1, 1050);
            Console.WriteLine("Gewicht:" + myMaserati.Gewicht);

            Console.ReadKey();
        }
    }
}
