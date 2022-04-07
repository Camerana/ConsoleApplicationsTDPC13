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
}
