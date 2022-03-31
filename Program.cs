using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    class Program
    {
        /*
        - creare una classe Mobile con properties:
                - public string Altezza
                - public string Colore
        - creare una classe Tavolo che eredita da Mobile
        - creare una classe Armadio che eredita da Mobile
        - creare un oggetto di tipo Tavolo e un oggetto di
        tipo Armadio e valorizzarne le properties
        - tramite una funzione StampaMobile(...) nella classe
        Program stampare le properties di tavolo e armadio
         */
        static void Main(string[] args)
        {
            Tavolo t = new Tavolo();
            t.Altezza = 100;
            t.Colore = "Rosso";

            Armadio a = new Armadio();
            a.Altezza = 180;
            a.Colore = "Bianco";

            StampaMobile(t);
            StampaMobile(a);
            Console.ReadKey();
        }
        public static void StampaMobile(Mobile m)
        {
            Console.WriteLine("Altezza: " + m.Altezza);
            Console.WriteLine("Colore: " + m.Colore);
        }
        /*
        static void Main(string[] args)
        {
            Animale animale = new Animale();
            Cane cane = new Cane();
            Bulldog bulldog = new Bulldog();
            Funzione(animale);
            Funzione(cane);
            Funzione(bulldog);
        }
        public static void Funzione(Bulldog pinco)
        {

        }
        */
        /*
        static void Main(string[] args)
        {
            for (int i = 0; i < 1598458; i++)
            {
                Animale.FaiIlVerso();
                Console.WriteLine(Animale.AnimalsNumber);
            }
            Console.ReadKey();
        }
        */
    }
}
