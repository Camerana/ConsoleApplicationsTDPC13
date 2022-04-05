using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Veicolo
    {
        public string Targa { get; set; }
        public string Colore { get; set; }
        public void Parti()
        {
        }
        protected virtual void Accendi()
        {
        }
    }
    public class Auto : Veicolo
    {
        public int NumeroPorte { get; set; }
        public void MettiLaCintura()
        {
        }
        protected override void Accendi()
        {
        }
        private void CambiaMarcia() { }
    }
    public class Moto : Veicolo
    {
        public int NumeroRaggi { get; set; }
        public void Impenna() { }
        protected override void Accendi() { }
    }
}