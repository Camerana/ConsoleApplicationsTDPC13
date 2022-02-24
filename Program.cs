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
          - creare un array con 5 numeri interi
          - creare una lista con 5 numeri interi
          - stampare il contenuto delle collections
         */
        /*
        static void Main(string[] args)
        {
          int[] numeriArray = new int[5];
          numeriArray[0] = 11;
          numeriArray[1] = 1;
          numeriArray[2] = 4;
          numeriArray[3] = 77;
          numeriArray[4] = 16;
          for (int i = 0; i < numeriArray.Length; i++)
            Console.WriteLine(numeriArray[i]);

          List<int> numeriList = new List<int>();
          numeriList.Add(144);
          numeriList.Add(14);
          numeriList.Add(1);
          numeriList.Add(666);
          numeriList.Add(56);
          for (int i = 0; i < numeriList.Count; i++)
            Console.WriteLine(numeriList[i]);

          Console.ReadKey();
        }
        */
        /*
         scrivere un programma:
          - creare un array di 5 stringhe
          - creare una lista di 5 numeri interi
          - stampare su schermo, insieme nello stesso WriteLine,
            ciascun elemento con lo stesso indice nelle due collection
         */
        /*
        static void Main(string[] args)
        {
          string[] stringhe = new string[5];
          stringhe[0] = "asda";
          stringhe[1] = "111";
          stringhe[2] = "4555";
          stringhe[3] = "jjjj";
          stringhe[4] = "56547";

          List<int> numeri = new List<int>();
          numeri.Add(14124);
          numeri.Add(555);
          numeri.Add(33);
          numeri.Add(11);
          numeri.Add(0);

          for (int i = 0; i < stringhe.Length; i++)
          {
            Console.WriteLine(stringhe[i] + " " + numeri[i]);
          }
          Console.ReadKey();
        }
        */
        /*
         scrivere un programma:
          - chiedere all'utente due numeri interi
          - creare un array e una lista di dimensioni pari, rispettivamente,
          al primo e al secondo numero dell'utente
          - popolare le due collection con elementi qualsiasi
          - tramite un solo ciclo stampare tutti gli elementi delle
          due collections
         */
        static void Main(string[] args)
        {
            //esempio di try catch parlante
            /*
            int numero = 12;
            int numero2 = 0;
            try
            {
                int numero3 = numero / numero2;
                Console.WriteLine("asda");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            */


            Console.WriteLine("Inserisci la dimensione dell'array");
            int arrayDimension = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la dimensione della lista");
            int listDimension = int.Parse(Console.ReadLine());

            int[] numbersArray = new int[arrayDimension];
            for (int i = 0; i < arrayDimension; i++)
                numbersArray[i] = i;

            List<int> numbersList = new List<int>();
            for (int i = 0; i < listDimension; i++)
                numbersList.Add(i);

            int maxDimension = 0;
            if (arrayDimension > listDimension)
                maxDimension = arrayDimension;
            else
                maxDimension = listDimension;

            for (int i = 0; i < maxDimension; i++)
            {
                if (i < arrayDimension)
                    Console.WriteLine("Array: " + numbersArray[i]);
                if (i < listDimension)
                    Console.WriteLine("Lista: " + numbersList[i]);



                //versione pigra, da NON imitare
                /*
                try
                {
                    Console.WriteLine("Array: " + i + " " + numbersArray[i]);
                }
                catch
                {
                    Console.WriteLine("Errore nell'array");
                }
                try
                {
                    Console.WriteLine("Lista: " + i + " " + numbersList[i]);
                }
                catch
                {
                    Console.WriteLine("Errore nella lista");
                }
                */
            }

            Console.ReadKey();
        }
    }
}
