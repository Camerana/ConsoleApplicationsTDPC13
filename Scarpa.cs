using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    class Scarpa
    {
        public string Numero { get; set; }
        public string Marca { get; set; }
        public void StampaCaratteristiche()
        {
            Console.WriteLine("Caratteristiche Scarpa:");
            Console.WriteLine("Il numero è " + this.Numero);
            Console.WriteLine("La marca è " + this.Marca);
        }
    }
}
