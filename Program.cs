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
         creare una classe Animale con:
            - properties:
                - string Nome
                - string Razza
            - costruttore vuoto (di default)
            - costruttore con parametro:
                - string nome
            - costruttore con parametri:
                - string nome
                - string razza
            - metodo Muoviti()
        creare un totale di 3 oggetti della classe Animale usando tutti e 3 
        i costruttori, valorizzarne le properties e per ciascuno
        eseguire il metodo Muoviti()
         */
        static void Main(string[] args)
        {
            Animale a1 = new Animale();
            a1.Nome = "Lino";
            a1.Razza = "Canguro";
            Animale a2 = new Animale("Piccio");
            a2.Razza = "Criceto";
            Animale a3 = new Animale("Ciccio", "Gatto");
            a1.Muoviti();
            a2.Muoviti();
            a3.Muoviti();
            Console.ReadKey();
        }
        /*
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Gino", "Paoli", true);
            Persona persona2 = new Persona("Claudio", "Villa", false);
            Persona persona3 = new Persona("Fred", "Bongusto", true);
        }
        */
    }
}
