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
    }
}
