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
         esercizio cattivo per sadomasochisti ]:-)
            - creare un gioco di ruolo tesuale con:
                - classe Player con:
                    - properties:
                        - string Name
                        - int HealthPoints (HP)
                        - int Damage
                        - int Gold
                    - metodi:
                        - Attack() per attaccare i nemici
                        - Heal() per guarirsi di una certa quantità di HP
                - classe Enemy con:
                    - properties:
                        - string Name
                        - int HealthPoints (HP)
                        - int Damage
                        - int Loot
                    - metodi:
                        - Attack() per attaccare il giocatore
                        - opzionale: Heal() per guarirsi di una certa quantità di HP
            - simulare delle battaglie tra l'oggetto di tipo Player
            e vari oggetti di tipo Enemy
            - quando il giocatore o un nemico viene colpito, perde una
            quantità di HP pari al Damage dell'attaccante, e quando i suoi
            HP arrivano a 0 muore
            - quando un nemico muore, lascia una ricompensa al giocatore
            pari al suo Loot, che viene aggiunto al Gold del giocatore
            - opzionali:
                - implementare eventuali altre interazioni tra Player e Enemy
                quali fuga dalla battaglia, incantesimi, diversi tipi di armi,
                armature
                - dopo ogni battaglia dare la possibilità al Player di comprare
                nuove armi o aumentare le proprie statistiche
                - decidere le condizioni finali di vittoria, quali un tot di
                Gold da raggiungere, un tot di nemici da uccidere, uno specifico
                nemico da uccidere
         */

        /*
        - creare una classe Automobile con
            - properties:
                - Colore
                - Targa:
                    - questa property deve sostituire,
                    nel set, i primi 3 caratteri 
                    della targa con un *
            - metodi:
                - Accendi()
        - creare 10 istanze della classe Automobile
        tramite un ciclo for
        - (tramite un altro ciclo, o lo stesso ?)
        valorizzare per ciascun oggetto le properties
        Colore e Targa ed eseguire il metodo Accendi

         */
        static void Main(string[] args)
        {
            List<Automobile> automobili = new List<Automobile>();
            Automobile[] autoArray = new Automobile[10];
            for (int i = 0; i < 10; i++)
            {
                Automobile auto = new Automobile();
                auto.Colore = "Rosso_" + i;
                auto.Targa = "AB22" + i + "SS";
                auto.Accendi();
                automobili.Add(auto);
                autoArray[i] = auto;
            }
            Console.ReadKey();
        }


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
        /*
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
        */
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
