using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Rubrica
    {
        public List<Contatto> Contatti { get; set; } = new List<Contatto>();

        public void AggiungiContatto()
        {
            Contatto contatto = new Contatto();
            Console.WriteLine("Inserisci il nome:");
            contatto.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome:");
            contatto.Cognome = Console.ReadLine();
            Console.WriteLine("Inserisci il numero di telefono:");
            contatto.Telefono = Console.ReadLine();
            this.Contatti.Add(contatto);
        }

        public void StampaContatti(List<Contatto> contatti = null)
        {
            List<Contatto> daStampare = null;
            if (contatti != null)
                daStampare = contatti;
            else
                daStampare = this.Contatti;
            for (int i = 0; i < daStampare.Count; i++)
            {
                Console.WriteLine(i + ")" + daStampare[i].Nome + " " + daStampare[i].Cognome + " " + daStampare[i].Telefono);
            }
        }

        public List<Contatto> CercaContatti()
        {
            Console.WriteLine("Inserisci il criterio:");
            string input = Console.ReadLine();
            List<Contatto> contattiTrovati = this.Contatti.Where(c =>
            c.Nome.Contains(input)
            || c.Cognome.Contains(input)
            || c.Telefono.Contains(input)).ToList();
            this.StampaContatti(contattiTrovati);
            return contattiTrovati;
        }

        public void CancellaContatto()
        {
            Console.WriteLine("Quale contatto vuoi eliminare ?");
            this.StampaContatti();
            string input = Console.ReadLine();
            int inputInt = 0;
            if (int.TryParse(input, out inputInt))
            {
                if (inputInt >= 0 && inputInt < this.Contatti.Count)
                    this.Contatti.RemoveAt(inputInt);
            }
        }

        public void ModificaContatto()
        {
            Console.WriteLine("Quale contatto vuoi modificare ?");
            this.StampaContatti();
            string input = Console.ReadLine();
            int inputInt = 0;
            if (int.TryParse(input, out inputInt))
            {
                if (inputInt >= 0 && inputInt < this.Contatti.Count)
                {
                    Contatto contatto = new Contatto();
                    Console.WriteLine("Inserisci il nome:");
                    contatto.Nome = Console.ReadLine();
                    Console.WriteLine("Inserisci il cognome:");
                    contatto.Cognome = Console.ReadLine();
                    Console.WriteLine("Inserisci il numero di telefono:");
                    contatto.Telefono = Console.ReadLine();
                    this.Contatti.RemoveAt(inputInt);
                    this.Contatti.Insert(inputInt, contatto);
                }
            }
        }
    }


    public class Contatto
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
    }


}

