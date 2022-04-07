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
         creare una classe astratta Vegetale
            - con property:
                - Altezza
            - con metodi:
                - Fiorisci()
        - creare una classe astratta Albero : Vegetale
            - con property:
                - TipologiaLegno
                - TipologiaFrutto
        - creare una classe Platano : Albero
            - con metodi:
                - ProduciBanane()
        - creare una classe Ulivo : Albero
            - con metodi:
                - ProduciOlive()
        - creare una classe Quercia : Albero
            - con metodi:
                - ViviTanto()
        - creare 10 oggetti di tipo Platano
        - creare un oggetto di tipo Ulivo
        - creare 15 oggetto di tipo Quercia
        - popolare e stampare su schermo le property degli oggetti
        - invocare da Program i metodi di tutti gli oggetti creati
         */
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Platano pl = new Platano();
                pl.Altezza = 150;
                pl.TipologiaFrutto = "tipo frutto platano";
                pl.TipologiaLegno = "tipo legno platano";
                Console.WriteLine(pl.Altezza);
                Console.WriteLine(pl.TipologiaFrutto);
                Console.WriteLine(pl.TipologiaLegno);
                pl.Fiorisci();
                pl.ProduciBanane();
            }

            Ulivo ul = new Ulivo();
            ul.Altezza = 170;
            ul.TipologiaFrutto = "tipo frutto ulivo";
            ul.TipologiaLegno = "tipo legno ulivo";
            Console.WriteLine(ul.Altezza);
            Console.WriteLine(ul.TipologiaFrutto);
            Console.WriteLine(ul.TipologiaLegno);
            ul.Fiorisci();
            ul.ProduciOlive();

            for (int i = 0; i < 15; i++)
            {
                Quercia q = new Quercia();
                q.Altezza = 150;
                q.TipologiaFrutto = "tipo frutto quercia";
                q.TipologiaLegno = "tipo legno quercia";
                Console.WriteLine(q.Altezza);
                Console.WriteLine(q.TipologiaFrutto);
                Console.WriteLine(q.TipologiaLegno);
                q.Fiorisci();
                q.ViviTanto();
            }
            Console.ReadKey();
        }
        /*
        static void Main(string[] args)
        {
            Pesce ps = new Pesce();
            Gatto gt = new Gatto();
            Canarino cn = new Canarino();

            Metodo(ps);
            Metodo(gt);
            Metodo(cn);
        }
        static void Metodo(Animale animale)
        {
            animale.Mangia();
            animale.Muoviti();
        }
        */
    }
}
