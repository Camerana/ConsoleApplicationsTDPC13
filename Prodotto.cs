using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public abstract class Prodotto
    {
        public string Nome { get; set; }
        public int Costo { get; set; }
    }
    public class Acqua : Prodotto
    {
    }
    public class Patatine : Prodotto
    {
    }
    public class Coca : Prodotto
    {
    }
    public class Noccioline : Prodotto
    {
    }
}
