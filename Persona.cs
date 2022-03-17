using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    class Persona
    {
        private string nome;
        public string Nome
        {
            get
            {
                return this.nome + " dal Get";
            }
            set
            {
                this.nome = value + " dal Set";
            }
        }
        public string Cognome { get; set; }
    }
}
