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
         creare una rubrica con:
            - aggiunta contatti
            - consultazione di tutti contatti
            - ricerca contatti
            - opzionale: cancellazione contatti
            - opzionale per masochisti: modifica contatti
         */
        static void Main(string[] args)
        {
            Rubrica rubrica = new Rubrica();
            while (true)
            {
                Console.WriteLine("Cosa vuoi fare ?");
                Console.WriteLine("0) Aggiungi contatto");
                Console.WriteLine("1) Stampa tutti i contatti");
                Console.WriteLine("2) Cerca contatti");
                Console.WriteLine("3) Modifica contatto");
                Console.WriteLine("4) Elimina contatto");
                string input = Console.ReadLine();
                Console.Clear();
                if (input == "0")
                {
                    rubrica.AggiungiContatto();
                    Console.Clear();
                }
                else if (input == "1")
                {
                    rubrica.StampaContatti();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "2")
                {
                    rubrica.CercaContatti();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "3")
                {
                    rubrica.ModificaContatto();
                    Console.Clear();
                }
                else if (input == "4")
                {
                    rubrica.CancellaContatto();
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}
