using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sladkarnsta
{
    internal class Produkt
    {
        public string Name { get; set; }
        public double Cena { get; set; }
        public int Koli4estvo { get; set; }
        public Produkt(string name, double cena, int koli4estvo)
        {
            if (name.Length > 10)
            {
                name = name.Substring(0, 10); 
            }

            Name = name;
            Cena = cena;
            Koli4estvo = koli4estvo;
        }
           public void Pokazvane()
            {
                Console.WriteLine($"Име: {Name}, Цена: {Cena:F2}, Количество: {Koli4estvo}");
            }
    }
}
