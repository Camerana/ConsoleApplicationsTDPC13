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
      /*
      string stringa = "amico";
      char secondoCarattere = stringa[1];

      Console.WriteLine(stringa);
      Console.WriteLine(secondoCarattere);
      */

      /*
       chiedere all'utente il suo nome
       stampare su schermo il nome dell'utente e il primo carattere
        del nome
       */
      /*
      Console.WriteLine("come ti chiami ?");
      string nome = Console.ReadLine();
      Console.WriteLine("ti chiami: " + nome);
      Console.WriteLine(nome[0]);
      */

      /*
       chiedere all'utente il suo nome
       stampare su schermo:
        - il nome dell'utente
        - il primo carattere del nome
        - l'ultimo carattere del nome
       */
      /*
      Console.WriteLine("come ti chiami ?");
      string nome = Console.ReadLine();
      Console.WriteLine("ti chiami: " + nome);
      Console.WriteLine(nome[0]);
      Console.WriteLine(nome[nome.Length-1]);
      */
      /*
      string stringa = "ciao sono una stringa molto lunga";
      //replace
      string stringaReplace = stringa.Replace("i", "I");

      //minuscolo
      string stringaLowerInvariant = stringa.ToLowerInvariant();

      //maiuscolo
      string stringaUpperInvariant = stringa.ToUpperInvariant();

      //comincia con questa stringa ?
      bool stringaStartsWith = stringa.StartsWith("cia");

      //finisce con questa stringa ?
      bool stringaEndsWith = stringa.EndsWith("nga");

      //contiene questa stringa ?
      bool stringaContains = stringa.Contains(" una st");


      Console.WriteLine(stringa);
      Console.WriteLine(stringaReplace);
      Console.WriteLine(stringaLowerInvariant);
      Console.WriteLine(stringaUpperInvariant);
      Console.WriteLine(stringaStartsWith);
      Console.WriteLine(stringaEndsWith);
      Console.WriteLine(stringaContains);
      */
      /*
        - chiedere all'utente una stringa qualsiasi
        - sostituire nella stringa tutte le occorrenze di "o" con "y"
        e stampare il risultato
        - sostituire nella stringa risultato tutte le occorrenze di
        "la" con "io" e stampare il risultato
       */
      /*
      Console.WriteLine("inserisci una stringa");
      string input = Console.ReadLine();
      string replaceOY = input.Replace("o", "y");
      Console.WriteLine(replaceOY);
      Console.WriteLine(replaceOY.Replace("la", "io"));
      */

      /*
       - chiedere all'utente una stringa
       - chiedere all'utente il suo nome
       - sostituire all'interno della prima stringa
      il nome dell'utente con "***"
       - stampare il risultato
       */
      /*
      Console.WriteLine("inserisci una stringa");
      string stringa = Console.ReadLine();
      Console.WriteLine("inserisci il tuo nome");
      string nome = Console.ReadLine();
      Console.WriteLine(stringa.Replace(nome, "***"));
      */



      Console.ReadKey();
    }

    //ESERCIZI:
    /*
     scrivere un programma che simuli il gioco del tris:
      - 2 giocatori
      - box di 3x3, simboli O, X
      - vince il giocatore che fa tris
     */
    /*
     - chiedere all'utente 4 numeri interi
     - stampare sullo schermo somma e differenza dei numeri
     - stampare sullo schermo il prodotto del primo con l'ultimo
     */
    /*
     - chiedere all'utente 3 stringhe
     - stampare sullo schermo le seguenti condizioni (true o false):
      - la prima stringa contiene la seconda
      - la seconda stringa comincia con la prima
      - la terza stringa è più lunga della prima
     */
  }
}
