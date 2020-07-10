using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport
{
    class Program
    {
        static void Main()
        {
            TomoGachi Ivan = new TomoGachi();
            Console.WriteLine("Нажмите любую клавишу, чтобы начать игру.");
            Console.ReadKey();
            Console.Clear();
            Ivan.Menu();

            while (true)
            {
                string command = Console.ReadLine();

                Random damage = new Random();
                Ivan.dmg = damage.Next(0, 100);

                if (Ivan.fed == 0)
                {
                    Ivan.HP -= 10;
                }

                if (Ivan.happiness == 0)
                {
                    Ivan.HP = 0;   
                }
                if (Ivan.HP == 0)
                {
                    Console.WriteLine("*Ivan прыгнул с ЧСВ на IQ разработчиков*");
                    Console.WriteLine("Gay Over");
                    Console.ReadKey();
                    Ivan.dead -= 1;
                }

                if (Ivan.dead == 0 || command == "Выход")
                    break;

                switch (command)
                {
                    case "1":
                        { 
                            Ivan.Eating();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;
                        }
                    case "2":
                        {
                            Ivan.Tool();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;
                        }
                    case "3":
                        {
                            Ivan.Spat();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;
                        }
                    case "4":
                        {
                            Ivan.Mat();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;
                        }
                    case "5":
                        {
                            Ivan.Olivie();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;
                        }
                    case "6":
                        {
                            Ivan.Maria();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;
                        }
                    case "7":
                        {
                            Ivan.Fotch();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;
                        }
                    case "8":
                        {
                            Ivan.Set();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;
                        }
                    case "9":
                        {
                            Ivan.Tur();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;

                        }
                    case "10":
                        {
                            Ivan.Club ();
                            Ivan.Max();
                            Ivan.Min();
                            Console.ReadKey();
                            Console.Clear();
                            Ivan.Menu();
                            break;
                        }
                }
            }
    
        }

    }
}