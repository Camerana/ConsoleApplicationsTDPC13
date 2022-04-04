using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    /*
     public:
        - sempre visibile
        - si eredita
    protected:
        - visibile:
            - stessa classe
            - classi figlie
        - si eredita
    private:
        - visile nella stessa classe
        - non si eredita
     */
    public class Animale
    {
        private string SonoPrivato;
        protected string SonoProtected;
        public string TipologiaArti { get; set; }
        public virtual void Mangia()
        {
            this.SonoPrivato = "sasfa";
            this.SonoProtected = "afagas";
            Console.WriteLine("L'animale sta mangiando");
        }
    }
    public class Elefante : Animale
    {
        public int NumeroZanne { get; set; }
        public override void Mangia()
        {
            //this.SonoPrivato = "aagagda";
            this.SonoProtected = "ggasfg";
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
