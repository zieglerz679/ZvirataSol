using System;
using System.Collections.Generic;
using Zvirata;
using Zvirata.NaseZvirata;

namespace ZvirataTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var zoo = VratZoo();

            OtestujHluk(zoo);
            Console.WriteLine("******************************");
            SeznamJidla(zoo);
        }

        private static void SeznamJidla(List<Zvire> zoo)
        {
            foreach (var zvire in zoo)
            {
                Console.WriteLine(zvire.Jmeno + " - " + zvire.OblibeneJidlo());
            }
        }

        private static void OtestujHluk(List<Zvire> zoo)
        {
            foreach (var zvire in zoo)
            {
                Console.WriteLine(zvire.Jmeno + " - " + zvire.Zvuk());
            }
        }

        private static List<Zvire> VratZoo()
        {
            List<Zvire> seznam = new List<Zvire>(10)
            {
                new Slon() { Jmeno = "Bimbo", DatumNarozeni = new DateTime(2005, 6, 7) },
                new Vlk() { Jmeno = "Starec", DatumNarozeni = new DateTime(1998, 5, 12) },
                new Zebra() { Jmeno = "Analka", DatumNarozeni = new DateTime(2015, 8, 20) },
                new Zebra() { Jmeno = "Karel", DatumNarozeni = new DateTime(2016, 7, 12) }
            };

            return seznam;
        }
    }
}
