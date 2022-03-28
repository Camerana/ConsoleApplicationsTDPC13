using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Automobile
    {
        public string Colore { get; set; }
        private string targa;
        public string Targa
        {
            get
            {
                return this.targa;
            }
            set
            {
                this.targa = "***" + value.Substring(3);
            }
        }
        public void Accendi()
        {
            Console.WriteLine(this.Targa + " è accesa");
        }
    }
}
