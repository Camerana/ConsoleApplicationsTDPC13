using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    class Persona
    {
        public string Name;
        public int Eta;

        public void StampaDati()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Eta);
        }
    }
}
