using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день игрок. Сколько у вас на руках карт? ");
            int numberСards = int.Parse(Console.ReadLine());
            int sum = 0;
            int Number = 0;
            Console.WriteLine("Введите наминал каждой карты.\nДля карт наминалом выше 10 используйте следующие обозначения:\n Валет - J\n Дама - Q\n Король - K\n Туз - T");

            for (int i = 1; i <= numberСards; i++)
            {
                string priceCard = (Console.ReadLine());
                switch (priceCard)
                {
                    case "T":
                        {
                            sum += 10;
                            continue;
                        }
                    case "J":
                        {
                            sum += 10;
                            continue;
                        }
                    case "Q":
                        {
                            sum += 10;
                            continue;
                        }
                    case "K":
                        {
                            sum += 10;
                            continue;
                        }
                }
                Number = int.Parse(priceCard);
                sum = sum + Number;
                continue;

            }
            Console.WriteLine($"Суммарный наминал ваших карт  = {sum}");
            Console.ReadKey();
        }
    }
}
