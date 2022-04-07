using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public interface IPersona
    {
        string Nome { get; set; }
        void Nutriti();
    }
    public interface IUmano : IPersona
    {
        void Mangia();
    }
    public interface IRobot : IPersona
    {
        void Ricarica();
    }
    public abstract class Umano : IUmano
    {
        public string Nome { get; set; }

        public void Nutriti()
        {
            this.Mangia();
        }
        public void Mangia() { }
    }
    public abstract class Robot : IRobot
    {
        public string Nome { get; set; }

        public virtual void Nutriti()
        {
            this.Ricarica();
        }
        public void Ricarica() { }
    }
    public class Impiegato : Umano
    {
    }
    public class Androide : Robot, IUmano
    {
        public override void Nutriti()
        {
            base.Nutriti();
            this.Mangia();
        }
        public void Mangia() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Impiegato impiegato = new Impiegato();
            Androide androide = new Androide();

            IPersona[] persone = new IPersona[2];
            persone[0] = impiegato;
            persone[1] = androide;

            persone[0].Nome = "jonny";
            persone[1].Nome = "joe porchetta";
            persone[0].Nutriti();
            persone[1].Nutriti();
        }
    }
}