using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Veicolo
    {
        public string Tipo { get; set; }
        private string colore;
        public string Colore
        {
            get
            {
                return this.colore;
            }
            set
            {
                //"Rosso", "Blu" e "Giallo"
                if (value.ToLowerInvariant() == "rosso"
                    || value.ToLowerInvariant() == "blu"
                    || value.ToLowerInvariant() == "giallo")
                    this.colore = value;
            }
        }
    }
}
