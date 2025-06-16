using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sladkarnsta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produkt> products = new List<Produkt>();
            Console.Write("Колко изделия ще въвеждаш (до 20 изделия): ");
            int count = int.Parse(Console.ReadLine());

            if (count > 20)
            {
                Console.WriteLine("Макс 20 изделия!");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nИзделие {i + 1} ");
                Console.Write("Име: ");
                string name = Console.ReadLine();

                Console.Write("Цена: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Количество: ");
                int koli4estvo = int.Parse(Console.ReadLine());

                products.Add(new Produkt(name, price, koli4estvo));
            }
            Console.WriteLine("Всички изделия: ");
            foreach (var p in products)
            {
                p.Pokazvane();
            }
            int minQuantity = products.Min(p => p.Koli4estvo);
            Console.WriteLine($"Минимално количество: {minQuantity}");
            foreach (var p in products.Where(p => p.Koli4estvo == minQuantity))
            {
                p.Pokazvane();
            }
        }
    }
}
