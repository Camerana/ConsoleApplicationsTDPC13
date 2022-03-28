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
            Automobile automobile = new Automobile();
            automobile.Colore = "Rosso";
            Sovrascrivi(automobile.Colore);
            Sovrascrivi(automobile);


            string coloreString = "Blu";
            Sovrascrivi(ref coloreString);

            Console.ReadKey();
        }
        /*
         i tipi di base vengono passati per value,
        gli oggetti vengono passati per reference !
         */
        public static void Sovrascrivi(string colore)
        {
            colore = "Giallo";
        }
        /*
         scrivendo la parola chiave "ref" si forza il comportamento
        della variabile, passandola per reference invece che per value
         */
        public static void Sovrascrivi(ref string colore)
        {
            colore = "Giallo";
        }
        public static void Sovrascrivi(Automobile auto)
        {
            auto.Colore = "Verde";
        }
    }
}

