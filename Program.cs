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
      Console.ReadKey();
    }
  }
}
