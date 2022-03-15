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
         scrivere un programma con:
          - una classe Persona con:
                public string Nome;
                public string Cognome;
          - una classe Animale
                public string Nome;
                public bool Mammifero;
          - creare un oggetto di tipo Persona e valorizzarne le properties
          - creare un oggetto di tipo Animale e valorizzarne le properties
          - stampare le properties dei due oggetti
         */
        static void Main(string[] args)
        {

        }
        /*
        - creare una classe Animale con:
            - public string Nome
            - public string Razza
        - chiedere all'utente nome e razza di un animale
        - creare un oggetto di tipo Animale e valorizzarne
        le properties secondo quanto scritto dall'utente
        - stampare su schermo le properties dell'oggetto
         */
        /*
        static void Main(string[] args)
        {
            Animale animale = new Animale();
            Console.WriteLine("Inserisci il nome dell'animale");
            animale.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci la razza dell'animale");
            animale.Razza = Console.ReadLine();

            animale.StampaDati();
            Console.ReadKey();
        }
        */
        /*
    creare una classe Persona con properties:
       - public string Name
       - public int Eta
    creare 2 oggetti di tipo Persona
    stampare su schermo le property dei due oggetti
    */
        /*
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona();

            persona1.Name = "Fabrizio";
            persona1.Eta = 25;

            persona2.Name = "Michele";
            persona2.Eta = 60;


            Console.WriteLine(persona1.Name);
            Console.WriteLine(persona1.Eta);

            Console.WriteLine(persona2.Name);
            Console.WriteLine(persona2.Eta);

            //questi hanno lo stesso output di sopra
            persona1.StampaDati();
            persona2.StampaDati();

            Console.ReadKey();
        }
        */
    }
}
