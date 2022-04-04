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
        - creare una classe Veicolo
            - properties:
                - Targa
                - Colore
            - metodi:
                - public Parti
                - protected virtual Accendi
        - creare una classe Auto : Veicolo
            - properties:
                - NumeroPorte
            - metodi:
                - public MettiLaCintura
                - protected override Accendi
                - private CambiaMarcia
        - creare una classe Moto : Veicolo
            - properties:
                - NumeroRaggi
            - metodi:
                - public Impenna
                - protected override Accendi
        - creare un oggetto di tipo Auto
        - creare un oggetto di tipo Moto
        - popolare le properties degli oggetti
        - invocare per ciascun oggetto tutti i metodi visibili
        in Program
         */
        static void Main(string[] args)
        {

        }
        /*
            - creare una classe Animale
                - con property string TipologiaArti
                - con metodo Mangia
            - creare una classe Elefante : Animale
                - con metodo Corri
            - creare una classe Pesce : Animale
                - con metodo Nuota
            - istanziare un oggetto di tipo Elefante
                - popolarne le properties
                - invocare i metodi Mangia e Corri
            - istanziare un oggetto di tipo Pesce
                - popolarne le properties
                - invocare i metodi Mangia e Nuota
         */
        /*
        static void Main(string[] args)
        {
            Elefante el = new Elefante();
            el.TipologiaArti = "Zampe";
            //el.Mangia();
            //el.Corri();

            Pesce ps = new Pesce();
            ps.TipologiaArti = "Pinne";
            //ps.Mangia();
            //ps.Nuota();

            AnimaleSconosciuto animScon = new AnimaleSconosciuto();
            animScon.TipologiaArti = "Tentacoli";
            //animScon.Mangia();

            OsservaAnimale(el);
            OsservaAnimale(ps);
            OsservaAnimale(animScon);

            Console.ReadKey();
        }
        public static void OsservaAnimale(Animale a)
        {
            a.Mangia();
        }
        */
        /*
        static void Main(string[] args)
        {
            Tavolo tavolo = new Tavolo();
            tavolo.Altezza = 100;
            tavolo.Colore = "Rosso";

            Armadio armadio = new Armadio();
            armadio.Altezza = 200;
            armadio.Colore = "Nero";

            tavolo.StampaMobile();
            armadio.StampaMobile();

            Console.ReadKey();
        }
        */
    }
}
