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
      string nome = "Francesco";
      Console.WriteLine(nome);

      Console.ReadKey();
      */
      /*
      int numero = 12;
      int numero2 = 1;
      int somma = numero + numero2;
      Console.WriteLine(somma);
      Console.ReadKey();
      */

      /*
       - scrivere un programma che:
        - date due stringhe, ne stampi la concatenazione
        - dati due numeri, ne stampi somma e differenza       
       */
      /*
      string stringa1 = "questa è la stringa 1";
      string stringa2 = "questa è la stringa 2";
      Console.WriteLine(stringa1 + " " + stringa2);
      Console.ReadKey();

      int numero1 = 10;
      int numero2 = 5;
      Console.WriteLine(numero1 + numero2);
      Console.WriteLine(numero1 - numero2);
      Console.WriteLine("La somma dei numeri è: " + (numero1 + numero2));
      Console.WriteLine("La differenza dei numeri è: " + (numero1 - numero2));
      Console.ReadKey();
      */


      Console.WriteLine("int");
      Console.WriteLine(int.MinValue);
      Console.WriteLine(int.MaxValue);

      Console.WriteLine("double");
      Console.WriteLine(double.MinValue);
      Console.WriteLine(double.MaxValue);

      Console.WriteLine("float");
      Console.WriteLine(float.MinValue);
      Console.WriteLine(float.MaxValue);

      Console.WriteLine("UInt16");
      Console.WriteLine(UInt16.MinValue);
      Console.WriteLine(UInt16.MaxValue);

      Console.ReadKey();
    }
  }
}
