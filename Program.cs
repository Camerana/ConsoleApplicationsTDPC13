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
     scrivere un programma:
      - chiedere all'utente un numero
      - ciclare da 0 fino al numero dato dall'utente
      - per ogni iterazione stampare l'indice dell'iterazione corrente
     */
    /*
    static void Main(string[] args)
    {
      Console.WriteLine("Inserisci un numero");
      string input = Console.ReadLine();
      int max = int.Parse(input);
      for (int i = 0; i < max; i++)
      {
        Console.WriteLine(i);
      }
      Console.ReadKey();
    }
    */
    /*
    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++)
      {
        for (int j = 0; j < 10; j++)
        {
          Console.WriteLine("i: " + i + ", j: " + j);
        }        
      }
      Console.ReadKey();
    }
    */
    /*
     scrivere un programma:
      - chiedere all'utente un numero
      - ciclare partendo dal numero dell'utente per 20 volte
      - stampare a ogni iterazione l'indice del ciclo
     */
    /*
    static void Main(string[] args)
    {
      Console.WriteLine("Inserisci un numero");
      int input = int.Parse(Console.ReadLine());

      for (int i = input; i < (input + 20); i++)
      {
        Console.WriteLine(i - input);
      }
      Console.ReadKey();
    }
    */
    /*
     * in un solo ciclo di 5 iterazioni:
        - chiedere all'utente una stringa
        - stampare sullo schermo la stringa
     */
    static void Main(string[] args)
    {
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine("Inserisci una stringa");
        string input = Console.ReadLine();
        Console.WriteLine(input);
      }
    }
  }
}
