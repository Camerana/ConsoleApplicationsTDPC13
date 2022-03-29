using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Animale
    {
        public string Nome { get; set; }
        private string razza;
        public string Razza
        {
            get
            {
                return this.razza;
            }
            set
            {
                //"Gatto" e "Canarino"
                if (value.ToLowerInvariant() == "gatto"
                    || value.ToLowerInvariant() == "canarino")
                    this.razza = value;
            }
        }
        public void Muoviti()
        {
        }
    }
}
