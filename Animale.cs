using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Animale
    {
        public string TipologiaArti { get; set; }
        public virtual void Mangia()
        {
            Console.WriteLine("L'animale sta mangiando");
        }
    }
    public class Elefante : Animale
    {
        public int NumeroZanne { get; set; }
        public override void Mangia()
        {
            Console.WriteLine("L'elefante sta mangiando");
        }
        public void Corri()
        {
            Console.WriteLine("L'elefante sta correndo");
        }
    }
    public class Pesce : Animale
    {
        public int NumeroBranchie { get; set; }
        public override void Mangia()
        {
            Console.WriteLine("Il pesce sta mangiando");
        }
        public void Nuota()
        {
            {
                Console.WriteLine("Il pesce sta nuotando");
            }
        }
    }

    public class AnimaleSconosciuto : Animale
    {

    }
}
