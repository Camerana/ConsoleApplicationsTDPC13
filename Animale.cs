using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public abstract class Animale
    {
        public void Mangia() { }
        public virtual void Muoviti() { }
    }
    public class Pesce : Animale
    {
        public override void Muoviti() { }
    }
    public class Gatto : Animale
    {
        public override void Muoviti() { }
    }
    public class Canarino : Animale
    {
        public override void Muoviti() { }
    }
}
