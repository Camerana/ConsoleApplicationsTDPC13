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
         - creare:
            - interfaccia IVivente
                - classe astratta Animale
                    - classe Cane
                    - classe Gatto
                - classe astratta Vegetale
                    - classe Albero
                    - classe Fiore
        - definire a qualsiasi livello delle properties e dei metodi
        - istanziare un oggetto per ogni classe istanziabile,
        popolarne le properties e invocarne i metodi            
         */
        static void Main(string[] args)
        {
            Impiegato impiegato = new Impiegato();
            Androide androide = new Androide();

            IPersona[] persone = new IPersona[2];
            persone[0] = impiegato;
            persone[1] = androide;

            persone[0].Nome = "jonny";
            persone[1].Nome = "joe porchetta";
            persone[0].Nutriti();
            persone[1].Nutriti();
        }
    }
}