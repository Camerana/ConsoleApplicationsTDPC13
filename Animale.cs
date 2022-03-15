using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    class Animale
    {
        public string Nome;
        public string Razza;

        public void StampaDati()
        {
            Console.WriteLine("Nome: " + this.Nome + ", Razza: " + this.Razza);
        }
    }
}
