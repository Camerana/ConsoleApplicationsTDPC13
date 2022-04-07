using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public abstract class Vegetale
    {
        public int Altezza { get; set; }
        public void Fiorisci() { }
    }
    public abstract class Albero : Vegetale
    {
        public string TipologiaLegno { get; set; }
        public string TipologiaFrutto { get; set; }
    }
    public class Platano : Albero
    {
        public void ProduciBanane()
        {
            Console.WriteLine("Il platano sta producendo banane");
        }
    }
    public class Ulivo : Albero
    {
        public void ProduciOlive()
        {
            Console.WriteLine("L'ulivo sta producendo olive");
        }
    }
    public class Quercia : Albero
    {
        public void ViviTanto()
        {
            Console.WriteLine("La quercia vive a lungo");
        }
    }
}
