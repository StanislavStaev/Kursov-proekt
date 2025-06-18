using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sladkarnitsa_s_masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[20];
            double[] cena = new double[20];
            int[] koli4estvo = new int[20];

            Console.Write("Въведи макс 20 изделия: ");           
              int broi = int.Parse(Console.ReadLine());
            if (broi > 20)
            {
                Console.WriteLine("Твърде много изделия!");
                return;
            }
            else
            {            
                    for (int i = 0; i < broi; i++)
                    {       
                        Console.WriteLine($"\nИзделие {i + 1}:");
                        Console.Write("Име до 10 символа: ");
                        names[i] = Console.ReadLine();
                    if (names[i].Length > 10)
                    {
                        Console.WriteLine("Това са повече от 10 символа!");
                        return;
                    }              
                        Console.Write("Цена: ");
                        cena[i] = double.Parse(Console.ReadLine());
                        Console.Write("Количество: ");
                        koli4estvo[i] = int.Parse(Console.ReadLine());                     
                    }
                    Console.WriteLine("\n--- Списък на всички изделия ---");
                    for (int i = 0; i < broi; i++)
                    {
                        Console.WriteLine($"Име: {names[i]}, Цена: {cena[i]:F2} Количество: {koli4estvo[i]}");
                    }
                    int minkoli4estvo = koli4estvo[0];
                    for (int i = 1; i < broi; i++)
                    {
                        if (koli4estvo[i] < minkoli4estvo)
                            minkoli4estvo = koli4estvo[i];
                    }
                    Console.WriteLine("\n--- Изделия с минимално количество ---");
                    for (int i = 0; i < broi; i++)
                    {
                        if (koli4estvo[i] == minkoli4estvo)
                        {
                            Console.WriteLine($"Име: {names[i]}, Цена: {cena[i]:F2} Количество: {koli4estvo[i]}");
                        }
                    }
            }
        }
    }
}
