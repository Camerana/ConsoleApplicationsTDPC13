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
         - creare una classe Veicolo
            - property Tipo
            - property Colore
         - creare 5 oggetti di tipo Veicolo
        e valorizzarne le property
        - creare una classe Animale
            - property Nome
            - property Razza
            - metodo Muoviti()
        - creare 2 oggetti di tipo Animale
        e valorizzarne le property
        - fare in modo che gli unici colori possibili per
        il Veicolo siano "Rosso", "Blu" e "Giallo"
        e che le uniche razze possibili per Animale siano
        "Gatto" e "Canarino", ossia bisogna modificare il "set"
        delle property
         */
        static void Main(string[] args)
        {
        }

        /*
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
        */
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

