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
            for (int i = 0; i < 1598458; i++)
            {
                Animale.FaiIlVerso();
                Console.WriteLine(Animale.AnimalsNumber);
            }
        

            Console.ReadKey();
        }
    }
}
