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
      scrivere un programma:
       - creare un array di 5 numeri interi
       - tramite un ciclo for stampare su schermo i numeri     
      */
      /*
      int[] numeri = new int[5];
      numeri[0] = 5;
      numeri[1] = 15;
      numeri[2] = 56;
      numeri[3] = 11;
      numeri[4] = 7;
      for (int i = 0; i < numeri.Length; i++)
      {
        Console.WriteLine(numeri[i]);
      }
      Console.ReadKey();
      */
      /*
       dato un array di 5 numeri, copiarli su un array di 10 numeri
       */
      int[] numeri = new int[5];
      numeri[0] = 5;
      numeri[1] = 15;
      numeri[2] = 56;
      numeri[3] = 11;
      numeri[4] = 7;
      int[] numeri2 = new int[10];
      for (int i = 0; i < numeri.Length; i++)
        numeri2[i] = numeri[i];

      /*
       permettere di scegliere tra italiano e inglese
      chiedere una frase
      chiedere una parola
      controllare se la parola è contenuta nella frase
       */
      //string language = GetLanguage();
      /*
      if (language == "1")
      {
        Console.WriteLine("Inserisci una frase");
        string frase = Console.ReadLine();
        Console.WriteLine("Inserisci una parola");
        string parola = Console.ReadLine();
        if (frase.Contains(parola))
          Console.WriteLine("La frase contiene la parola");
        else
          Console.WriteLine("La frase NON contiene la parola");
      }
      else if (language == "2")
      {
        Console.WriteLine("Insert a sentence");
        string frase = Console.ReadLine();
        Console.WriteLine("Insert a word");
        string parola = Console.ReadLine();
        if (frase.Contains(parola))
          Console.WriteLine("The sentence contains the word");
        else
          Console.WriteLine("The sentence doesn't contains the word");
      }
      */
      /*
      if (language == "1")
        Console.WriteLine("Inserisci una frase");
      else if (language == "2")
        Console.WriteLine("Insert a sentence");
      string frase = Console.ReadLine();
      if (language == "1")
        Console.WriteLine("Inserisci una parola");
      else if (language == "2")
        Console.WriteLine("Insert a word");
      string parola = Console.ReadLine();
      if (frase.Contains(parola))
      {
        if (language == "1")
          Console.WriteLine("La frase contiene la parola");
        else if (language == "2")
          Console.WriteLine("The sentence contains the word");
      }
      else
      {
        if (language == "1")
          Console.WriteLine("La frase NON contiene la parola");
        else if (language == "2")
          Console.WriteLine("The sentence doesn't contains the word");
      }
      */
      /*
      string language = GetLanguage();
      if (language == "1")
        CheckSentence("Inserisci una frase",
          "Inserisci una parola",
          "La frase contiene la parola",
          "La frase NON contiene la parola"
          );
      else if (language == "2")
        CheckSentence("Insert a sentence",
          "Insert a word",
          "The sentence contains the word",
          "The sentence doesn't contains the word");
      */
      string language = GetLanguage();
      string[] translations = GetTranslations(language);
      CheckSentence(translations);
    }
    /*
    public static string GetLanguage()
    {
      string language = string.Empty;
      while (language != "1" && language != "2")
      {
        Console.WriteLine("Scegli:");
        Console.WriteLine("1 = Italiano");
        Console.WriteLine("2 = Inglese");
        language = Console.ReadLine();
      }
      return language;
    }
    public static void CheckSentence(string inserisciFrase,
      string inserisciParola,
      string fraseContiene,
      string fraseNONContiene)
    {
      Console.WriteLine(inserisciFrase);
      string frase = Console.ReadLine();
      Console.WriteLine(inserisciParola);
      string parola = Console.ReadLine();
      if (frase.Contains(parola))
        Console.WriteLine(fraseContiene);
      else
        Console.WriteLine(fraseNONContiene);
    }
    */
    public static string GetLanguage()
    {
      string language = string.Empty;
      while (language != "1" && language != "2")
      {
        Console.WriteLine("Scegli:");
        Console.WriteLine("1 = Italiano");
        Console.WriteLine("2 = Inglese");
        language = Console.ReadLine();
      }
      return language;
    }
    public static string[] GetTranslations(string language)
    {
      string[] traduzioni = new string[4];
      if (language == "1")
      {
        traduzioni[0] = "Inserisci una frase";
        traduzioni[1] = "Inserisci una parola";
        traduzioni[2] = "La frase contiene la parola";
        traduzioni[3] = "La frase NON contiene la parola";
      }
      else if (language == "2")
      {
        traduzioni[0] = "Insert a sentence";
        traduzioni[1] = "Insert a word";
        traduzioni[2] = "The sentence contains the word";
        traduzioni[3] = "The sentence doesn't contains the word";
      }
      return traduzioni;
    }

    public static void CheckSentence(string[] traduzioni)
    {
      Console.WriteLine(traduzioni[0]);
      string frase = Console.ReadLine();
      Console.WriteLine(traduzioni[1]);
      string parola = Console.ReadLine();
      if (frase.Contains(parola))
        Console.WriteLine(traduzioni[2]);
      else
        Console.WriteLine(traduzioni[3]);
    }
  }
}
