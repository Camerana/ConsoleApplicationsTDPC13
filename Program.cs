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
      scrivere e chiamare due funzioni:
       - la prima stampa "hello"
       - la seconda chiede un numero all'utente e lo stampa
      */
    /*
    static void Main(string[] args)
    {
      StampaHello();
      StampaNumero();    

      Console.ReadKey();
    }
    
    static void StampaHello()
    {
      Console.WriteLine("hello");
    }

    static void StampaNumero()
    {
      Console.WriteLine("Inserisci un numero");
      string numero = Console.ReadLine();
      Console.WriteLine(numero);
    }
    */
    /*
     scrivere una funzione che accetti in ingresso due numeri
    e ne stampi la somma
     */
    static void Main(string[] args)
    {
      int numero1 = 10;
      int numero2 = 5;
      StampaSomma(numero1, numero2);
      Console.ReadKey();
    }

    static void StampaSomma(int num1, int num2)
    {
      Console.WriteLine(num1 + num2);
    }
  }
}
