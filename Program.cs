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
         a grande richiesta torna....
        - il DISTRIBUTORE ! (fatto per bene)
            - considerare un credito X dell'utente
            - considerare 4 prodotti diversi
            - possibilità di continuare ad acquistare
            dopo il primo acquisto
         */
        static void Main(string[] args)
        {
            Distributore distributore = new Distributore();

            int credito = 10;
            Prodotto prodottoScelto = null;
            while (credito > 0)
            {
                Console.Clear();
                Console.WriteLine("Hai: " + credito + " euro");
                prodottoScelto = distributore.ScegliProdotto();
                if (prodottoScelto != null)
                {
                    if (credito >= prodottoScelto.Costo)
                    {
                        Console.WriteLine("Hai comprato " + prodottoScelto.Nome);
                        credito = credito - prodottoScelto.Costo;
                     
                    }
                    else
                    {
                        Console.WriteLine("Non hai abbastanza credito per comprare " + prodottoScelto.Nome);
                    }
                }
                else
                {
                    Console.WriteLine("Scelta non valida");
                }
                Console.ReadKey();
            }
            Console.WriteLine("Arrivederci");
            Console.ReadKey();
        }
    }
}
