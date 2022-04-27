using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Partita
    {
        public Giocatore Giocatore1 { get; set; } = new Giocatore();
        public Giocatore Giocatore2 { get; set; } = new Giocatore();
        public int TurnoMassimo = 100;
        public int TurnoCorrente = 0;

        public Partita()
        {
            this.Giocatore1.Nome = "Giocatore 1";
            this.Giocatore2.Nome = "Giocatore 2";
            this.RandomizePoints();
        }

        private void RandomizePoints()
        {
            Random random = new Random();
            this.Giocatore1.PuntiPanza = 10; //random.Next(50, 100);
            this.Giocatore2.PuntiPanza = 10;//random.Next(50, 100);
        }

        public void Start()
        {
            Giocatore attivo = Giocatore1;
            Giocatore passivo = Giocatore2;
            while (this.TurnoCorrente < this.TurnoMassimo)
            {
                Giocatore[] giocatori = this.Turno(attivo, passivo);
                attivo = giocatori[1];
                passivo = giocatori[0];
                this.TurnoCorrente++;
                if ((this.Giocatore1.PuntiPanza <= 0
                    || this.Giocatore2.PuntiPanza <= 0)
                    && this.TurnoCorrente % 2 == 0)
                {
                    break;
                }
            }
            this.Stop();
        }
        private void Stop()
        {
            if (this.Giocatore1.PuntiPanza > this.Giocatore2.PuntiPanza)
            {
                Console.WriteLine("Ha vinto: " + this.Giocatore1.Nome);
            }
            else if (this.Giocatore2.PuntiPanza > this.Giocatore1.PuntiPanza)
            {
                Console.WriteLine("Ha vinto: " + this.Giocatore2.Nome);
            }
            else
            {
                Console.WriteLine(this.Giocatore1.Nome + " e " + this.Giocatore2.Nome + " hanno pareggiato");
            }
            Console.ReadKey();
        }
        private void Intestazione()
        {
            Console.WriteLine("Punti panza: " + this.Giocatore1.Nome + " " + this.Giocatore1.PuntiPanza);
            Console.WriteLine("Punti panza: " + this.Giocatore2.Nome + " " + this.Giocatore2.PuntiPanza);
        }
        private Giocatore[] Turno(Giocatore attivo, Giocatore passivo)
        {
            Console.Clear();
            Console.WriteLine("Turno " + this.TurnoCorrente + "/" + this.TurnoMassimo + " (" + attivo.Nome + ")");
            this.Intestazione();
            Console.WriteLine();
            Console.WriteLine("Cosa vuoi fare ?");
            Console.WriteLine("1) Mangia una salsiccia");
            Console.WriteLine("2) Bevi una birra");
            string input = Console.ReadLine();
            Random random = new Random();
            if (input == "1")
            {
                attivo.PuntiPanza = attivo.PuntiPanza - 3;
                passivo.PuntiPanza = passivo.PuntiPanza - 2;

                if (random.Next(0, 100) > 45)
                {
                    attivo.PuntiPanza = attivo.PuntiPanza - 3;
                    Console.WriteLine("Non è andata a buon fine");
                }
                else
                    Console.WriteLine("E' andata a buon fine");
            }
            else if (input == "2")
            {
                attivo.PuntiPanza = attivo.PuntiPanza - 2;
                if (random.Next(0, 100) > 65)
                {
                    attivo.PuntiPanza = attivo.PuntiPanza - 2;
                    Console.WriteLine("Non è andata a buon fine");
                }
                else
                    Console.WriteLine("E' andata a buon fine");
            }
            Console.ReadKey();
            return new Giocatore[] { attivo, passivo };
        }
    }
}
