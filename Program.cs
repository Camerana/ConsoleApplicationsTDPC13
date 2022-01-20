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
       scrivere un programma che simuli un lancio di una moneta:
        - permettere all'utente di scommettere testa o croce
        - stampare all'utente se ha vinto o meno
       */
      Console.WriteLine("Scegli testa o croce");
      Console.WriteLine("1) testa");
      Console.WriteLine("2) croce");
      string scelta = Console.ReadLine();

      Random r = new Random();
      int randomNumber = r.Next(1, 3);
      if (scelta == randomNumber.ToString())
        Console.WriteLine("Hai vinto");
      else
        Console.WriteLine("Hai perso");

      Console.ReadKey();
    }
  }
}
