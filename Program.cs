using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    class Program
    {
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
