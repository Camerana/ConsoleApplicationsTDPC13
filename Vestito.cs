using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    class Vestito
    {
        public string Taglia { get; set; }
        public string Colore { get; set; }
        public void StampaCaratteristiche()
        {
            Console.WriteLine("Caratteristiche Vestito:");
            Console.WriteLine("La taglia è " + this.Taglia);
            Console.WriteLine("Il colore è " + this.Colore);
        }
    }
}
