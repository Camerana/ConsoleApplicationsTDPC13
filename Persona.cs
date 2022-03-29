using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Persona
    {
        private string nome;
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value + "ggg";
            }
        }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public Persona(string nome, string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }
        public Persona(string nome, string cognome, bool saluta)
        {
            this.Nome = nome;
            this.Cognome = cognome;

            if (saluta)
                Saluta(this.Nome);
        }
        public void Saluta(string nome)
        {
            Console.WriteLine("Ciao, sono " + nome);
        }
    }
}
