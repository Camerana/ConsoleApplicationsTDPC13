using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Mobile
    {
        public int Altezza { get; set; }
        public string Colore { get; set; }

        public void StampaMobile()
        {
            Console.WriteLine("Altezza: " + this.Altezza);
            Console.WriteLine("Colore: " + this.Colore);
        }
    }
    public class Tavolo : Mobile
    {
    }
    public class Armadio : Mobile
    {
    }
}
