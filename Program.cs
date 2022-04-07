using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public interface IPersona
    {
        void Mangia();
    }
    public interface IRobot
    {
        void Ricarica();
    }
    public abstract class Umano
    {
        public void Mangia() { }
    }
    public abstract class Robot
    {
        public void Ricarica() { }
    }
    public class Impiegato : Umano, IPersona
    {
    }
    public class Androide : Robot, IRobot, IPersona
    {
        public void Mangia() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Impiegato impiegato = new Impiegato();
            impiegato.Mangia();

            Androide androide = new Androide();
            androide.Mangia();
            androide.Ricarica();

            IPersona[] persone = new IPersona[2];
            persone[0] = impiegato;
            persone[1] = androide;
            persone[0].Mangia();

            IRobot[] robots = new IRobot[1];
            robots[0] = androide;
            robots[0].Ricarica();

            Androide[] androidi = new Androide[2];
            androidi[0] = androide;
            androidi[0].Mangia();
            androidi[0].Ricarica();
        }
    }
}