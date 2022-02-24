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
         scrivere un programma:
            - chiedere all'utente 3 numeri
            - inserire i 3 numeri in un array
            - tramite un ciclo foreach stampare i 3 numeri
         */
        static void Main(string[] args)
        {
            int[] numeri = new int[3];
            Console.WriteLine("Inserisci il primo numero");
            numeri[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero");
            numeri[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il terzo numero");
            numeri[2] = int.Parse(Console.ReadLine());

            foreach (int numero in numeri)
            {
                Console.WriteLine(numero);
            }
            /*
            List<string> stringhe = new List<string>() {
            "lista 1", "lista 2", "lista 3"
            };
            foreach (string stringa in stringhe)
                Console.WriteLine(stringa);

            int[] numeri = new int[] { 1, 2, 3 };

            foreach (int numero in numeri)
                Console.WriteLine(numero);
            */
            Console.ReadKey();
        }
    }
}
