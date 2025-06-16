using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov_proekt
{
    internal class Aroma
    {
        static void Main(string[] args)
        {
            List<Klient> clients = new List<Klient>();
            List<Poruchka> orders = new List<Poruchka>();
            List<Pla6tane> payments = new List<Pla6tane>();
            Console.Write("Колко записа ще въведете? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"--- Запис {i + 1} ---");
                Klient c = new Klient();
                Console.Write("Име на клиента ");
                c.Name = Console.ReadLine();
                Console.Write("Брой хора на масата ");
                c.Brojhora = int.Parse(Console.ReadLine());
                Console.Write("Номер на масата ");
                c.Masanomer = int.Parse(Console.ReadLine());
                clients.Add(c);

                Poruchka o = new Poruchka();
                Console.Write("Вид напитка ");
                o.Vidpiene = Console.ReadLine();
                Console.Write("Брой напитки ");
                o.Brojpiene = int.Parse(Console.ReadLine());
                Console.Write("Размер (малка, средна, голяма) ");
                o.Razmerpiene = Console.ReadLine();
                orders.Add(o);

                Pla6tane p = new Pla6tane ();
                Console.Write("Цена на напитка ");
                p.Cenapiene = double.Parse(Console.ReadLine());
                Console.Write("Начин на плащане (в брой / с карта) ");
                p.Pla6tanena4in = Console.ReadLine();
                payments.Add(p);
            }
            Console.WriteLine("\nВсички данни: ");
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine($"{clients[i].Name}, {clients[i].Brojhora} души, маса {clients[i].Masanomer}, " +
                                  $"{orders[i].Brojpiene} x {orders[i].Razmerpiene} {orders[i].Vidpiene}, " +
                                  $"{payments[i].Cenapiene:F2}лв, плащането е {payments[i].Pla6tanena4in}");
            }
            Console.WriteLine("\nСуми по маси: ");
            for (int i = 0; i < n; i++)
            {
                double total = payments[i].TotalPrice(orders[i].Brojpiene);
                Console.WriteLine($"Маса {clients[i].Masanomer} дължи {total:F2}лв");
            }
            Console.WriteLine("\nМалки напитки ");
            for (int i = 0; i < n; i++)
            {
                if (orders[i].Razmerpiene == "малка")
                {
                    Console.WriteLine($"{orders[i].Brojpiene} x {orders[i].Vidpiene} на маса {clients[i].Masanomer}");
                }
            }
            Console.WriteLine("\nГолеми напитки: ");
            for (int i = 0; i < n; i++)
            {
                if (orders[i].Razmerpiene == "голяма")
                {
                    Console.WriteLine($"{clients[i].Brojhora} души на маса {clients[i].Masanomer}");
                }
            }
            Console.WriteLine("\nМасите с номер над 5: ");
            for (int i = 0; i < n; i++)
            {
                if (clients[i].Masanomer > 5)
                {
                    double total = payments[i].TotalPrice(orders[i].Brojpiene);
                    Console.WriteLine($"Маса {clients[i].Masanomer} дължи {total:F2}лв");
                }
            }
            Console.WriteLine("\nСортиране на сума възходящо");
            var sorted = Enumerable.Range(0, n).OrderBy(i => payments[i].TotalPrice(orders[i].Brojpiene));
            foreach (var i in sorted)
            {
                double total = payments[i].TotalPrice(orders[i].Brojpiene);
                Console.WriteLine($"{clients[i].Name}, Маса {clients[i].Masanomer}, Сума: {total:F2}лв");
            }
        }
    }
}
