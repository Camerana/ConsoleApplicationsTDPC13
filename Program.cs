using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nome = "Franco";
            Console.WriteLine(persona.Nome);
            Console.ReadKey();

            
        }
    }
}
