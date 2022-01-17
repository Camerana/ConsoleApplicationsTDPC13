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

      /*
      bool valore1 = true;
      bool valore2 = false;
      Console.WriteLine(valore1);
      Console.WriteLine(valore2);      
      */

      /*
      string inputDellUtente = Console.ReadLine();
      Console.WriteLine(inputDellUtente);
      */

      /*
       scrivere un programma che:
        - chieda all'utente il suo nome
        - scriva sullo schermo "il tuo nome è + nome"
       */
      /*
      Console.WriteLine("Come ti chiami ?");
      string nome = Console.ReadLine();
      Console.WriteLine("Il tuo nome è: " + nome);
      */

      /*
      string numeroString = "10";
      int numeroInt = int.Parse(numeroString);      
      Console.WriteLine(numeroString);
      Console.WriteLine(numeroInt);
      */

      /*
       scrivere un programma che:
        - chieda all'utente due numeri (numero1 e numero2)
        - scriva sullo schermo numero1 + 1 (somma aritmetica)
        - scriva sullo schermo la somma dei due numeri
        - scriva sullo schermo la differenza dei due numeri
       */
      Console.WriteLine("Inserisci il primo numero");
      string numero1 = Console.ReadLine();
      Console.WriteLine("Inserisci il secondo numero");
      string numero2 = Console.ReadLine();
      int numero1Int = int.Parse(numero1);
      int numero2Int = int.Parse(numero2);
      Console.WriteLine("numero1 + 1 = " + (numero1Int + 1));
      Console.WriteLine("numero1 + numero2 = " + (numero1Int + numero2Int));
      Console.WriteLine("numero1 - numero2 = " + (numero1Int - numero2Int));
      Console.ReadKey();
    }
  }
}
