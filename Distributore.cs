using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC13
{
    public class Distributore
    {
        public List<Prodotto> Prodotti = new List<Prodotto>();

        public Distributore()
        {
            Prodotti.Add(new Acqua()
            {
                Costo = 2,
                Nome = "Acqua"
            });
            Prodotti.Add(new Patatine()
            {
                Costo = 1,
                Nome = "Patatine"
            });
            Prodotti.Add(new Coca()
            {
                Costo = 1,
                Nome = "Coca"
            });
            Prodotti.Add(new Noccioline()
            {
                Costo = 3,
                Nome = "Noccioline"
            });
        }

        public Prodotto ScegliProdotto()
        {
            Console.WriteLine("Che prodotto vuoi comprare ?");
            for (int i = 0; i < this.Prodotti.Count; i++)
            {
                Console.WriteLine(i + ")" + this.Prodotti[i].Nome + ", " + this.Prodotti[i].Costo + " euro");
            }
            string input = Console.ReadLine();
            int inputInt = 0;
            Prodotto prodottoScelto = null;
            if (int.TryParse(input, out inputInt))
            {
                if (inputInt >= 0 && inputInt < this.Prodotti.Count)
                {
                    prodottoScelto = this.Prodotti[inputInt];
                }
            }
            return prodottoScelto;
        }
    }
}
