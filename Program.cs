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



      Console.ReadKey();
    }
  }
}
