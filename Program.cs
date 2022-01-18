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
      Console.WriteLine("Inserisci una stringa");
      string variabile = Console.ReadLine();
      if (variabile == "ciao")
      {
        Console.WriteLine("ciao anche a te");
      }
      else if (variabile == "addio")
      {
        Console.WriteLine("addio mio caro");
      }
      else if (variabile == "goodbye")
      {
        Console.WriteLine("goodbye my friend");
      }
      else
      {
        Console.WriteLine("non mi saluti ?");
      }
      */
      /*
       scrivere un programma che:
        - chieda all'utente una stringa
        - confronti la stringa inserita con una stringa
        arbitraria
        - in caso di uguaglianza stampi su schermo
        "le stringhe sono uguali"
        - altrimenti stampi su schermo
        "le stringhe non sono uguali"
       */
      /*
      Console.WriteLine("inserisci una stringa");
      string stringa = Console.ReadLine();
      if (stringa == "stringa segreta")
        Console.WriteLine("le stringhe sono uguali");
      else
        Console.WriteLine("le stringhe non sono uguali");
      */
      /*versione che gira fino a quando l'utente non 
       indovina la stringa "asd"*/
      /*
      bool exitLoop = false;
      while (!exitLoop)
      {
        Console.WriteLine("inserisci una stringa");
        string stringa = Console.ReadLine();
        if (stringa == "asd")
        {
          exitLoop = true;
          Console.WriteLine("le stringhe sono uguali");
        }
        else
          Console.WriteLine("le stringhe non sono uguali");
      }
      */



      Console.ReadKey();
    }
  }
}
