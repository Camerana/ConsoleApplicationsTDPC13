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
         * - creare 2 classi:
         *  - Vestito con:
         *      - properties:
         *          - Taglia
         *          - Colore
         *      - metodi:
         *          - StampaCaratteristiche()
         *  - Scarpa con:
         *      - properties:
         *          - Numero
         *          - Marca
         *      - metodi:
         *          - StampaCaratteristiche()
         * - creare un oggetto per ciascuna classe
         * e valorizzarne le properties
         * - tramite i metodi StampaCaratteristiche
         * stampare le properties degli oggetti
         */
        static void Main(string[] args)
        {
            Vestito v = new Vestito();
            v.Taglia = "XXXXL";
            v.Colore = "Rosso";

            Scarpa s = new Scarpa();
            s.Numero = "52";
            s.Marca = "Prada";

            v.StampaCaratteristiche();
            s.StampaCaratteristiche();
        }
        /*
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nome = "Franco";
            Console.WriteLine(persona.Nome);
            Console.ReadKey();
        }
        */
    }
}
