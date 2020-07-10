using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport
{
    class TomoGachi
    {
        public sbyte dead = 1;
        public int HP = 100;
        public sbyte happiness = 50;
        public sbyte food = 100;
        public sbyte fed = 50;
        public sbyte toilet;
        public sbyte set_on;
        public sbyte seton_biyka;
        public sbyte gaypower = 50;
        public sbyte gege = 50;
        public sbyte gay;
        public int bucks = 300;
        public int dmg;

        public void Menu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1.Захотеть оливье.");
            Console.WriteLine("2.Пустить торпеду.");
            Console.WriteLine("3.Прикорнуть.");
            Console.WriteLine("4.Попросить у мамки денег");
            Console.WriteLine("5.Заказать оливье.");
            Console.WriteLine("6.Устроить поход на Иерусалим.(Ave Maria!).");
            Console.WriteLine("7.Чекает 4ch.");
            Console.WriteLine("8.Смотреть Yuri the Professional на СЕТОНЕ.");
            Console.WriteLine("9.X100 нагиб на SETOOOOON!");
            Console.WriteLine("10.Записаться в качалку.");
            Console.WriteLine("Введите <<Выход>>, чтобы выйти.");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("  HP    " + "  Счастье    " +" ГеГе за ШаГе "+ "  Энергия    " + "  Сытость   " + "  Еда    " + "  Nuke" + "");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine(" " + Convert.ToString(HP) + "        " + Convert.ToString(happiness) + "             " + Convert.ToString(gege)+ "           " + Convert.ToString(gaypower) + "          " + Convert.ToString(fed) + "        " + Convert.ToString(food) + "       " + Convert.ToString(toilet));
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        public void Max()
        {
            if (HP > 100)
            {
                HP = 100;
            }
            else { }
            if (happiness > 100)
            {
                happiness = 100;
            }
            else { }
            if (food > 100)
            {
                food = 100;
            }
            else { }
            if (fed > 100)
            {
                fed = 100;
            }
            else { }
            if (toilet > 100)
            {
                toilet = 100;
            }
            else { }
            if (set_on > 100)
            {
                set_on = 100;
            }
            else { }
            if (gaypower > 100)
            {
                gaypower = 100;
            }
            else { }
            if (seton_biyka > 100)
            {
                seton_biyka = 100;
            }
            else { }
            if (bucks > 300)
            {
                bucks = 300;
            }
            else { }
            if (gege > 50)
            {
                gege = 50;
            }
            else { }
        }
        public void Min()
        {
            if (HP < 0)
            {
                HP = 0;
            }
            else { }
            if (happiness < 0)
            {
                happiness = 0;
            }
            else { }
            if (food < 0)
            {
                food = 0;
            }
            else { }
            if (fed <0)
            {
                fed = 0;
            }
            else { }
            if (toilet < 0)
            {
                toilet = 0;
            }
            else { }
            if (set_on < 0)
            {
                set_on = 0;
            }
            else { }
            if (gaypower < 0)
            {
                gaypower = 0;
            }
            else { }
            if (seton_biyka < 0)
            {
                seton_biyka = 0;
            }
            else { }
            if (bucks < 0)
            {
                bucks = 0;
            }
            else { }
            if (gege < 0)
            {
                gege = 0;
            }
            else { }
        }
        public void Club()
        {
            Console.Clear();
            if (happiness == 100)
            {

                Console.WriteLine("Welcome to the club Ivan!");
                Console.WriteLine("*Тыщ*");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Game Over");
                HP = 0;
            }
            else
            {
                Console.WriteLine("Ivan не смог открыть дверь.");
            }
        }      
        public void Eating()
        {
            Console.Clear();
            Console.WriteLine("Ivan захотев оливье");
            Random poi = new Random();
            int poison = poi.Next(0, 99);
            if (poison != 0)
            {
                if (fed <= 90)
                {
                    if (food >= 10)
                    {
                        fed += 10;
                        food -= 10;
                        happiness += 10;
                        toilet += 5;
                        Console.WriteLine("Ivan покушав оливье");
                    }
                    else
                    {
                        Console.WriteLine("- Перехочешь");
                        Console.WriteLine("- Ну блин((");
                        happiness -= 10;
                    }
                }
                else
                {
                    Console.WriteLine("Ха-ха, обмануф))0)");
                }
            }
            else
            {
                Console.WriteLine("Ivan отравился");
                HP -= 10;
                fed -= 20;
                toilet += 10;
            }
        }
        public void Tool()
        {
            Console.Clear();
            Random ass = new Random();
            int o4ko = ass.Next(0, 99);
            if (o4ko != 0)
            {
                if (toilet > 0)
                {
                    Console.WriteLine("Ivan drop of shit (west)....");
                    toilet -= 20;
                    happiness += 10;
                    gaypower -= 10;
                }
                else
                {
                    Console.WriteLine("Ivan empty inside");
                }
            }
            else
            {
                Console.WriteLine("Ivan разорвал очко");
                HP -= dmg;
            }
        }
        public void Spat()
        {
            if (fed > 0)
            {
                Console.Clear();
                Console.WriteLine("Ивану приснилась кровать");
                gaypower += 50;
                fed -= 10;
                toilet += 10;
                if (toilet == 100)
                {
                    Console.Clear();
                    Console.WriteLine("Ivan снится хороший сон...");
                    Console.WriteLine("Слишком хороший сон...");
                    Console.WriteLine("Ivan чувствует облегчение...");
                    Console.WriteLine("Ivan проснулся с улыбкой на лице и со слезами на глазах...");
                    happiness = 0;
                    Console.ReadKey();
                }
                else{ }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Хочу оливье!");
            }
        }
        public void Mat()
        {
            Console.Clear();
            Console.WriteLine("-Мааааааааам, дай деняк");
            Random mam = new Random();
            int piz =  mam.Next(0, 19);
            if(piz != 0)
            {
                Console.WriteLine("-На сынок!");
                bucks += 20;
                happiness += 5;
            }
            else
            {
                Console.WriteLine("-Иди на завод, нахлебник!");
                Console.WriteLine("*Удар скалокой по скворечнику*");
                HP -= dmg;
                Console.WriteLine(dmg);
                happiness -= 50;
            }
        }
        public void Olivie()
        {
            Console.Clear();
                if (bucks >= 10)
                {
                    if (food <= 90)
                    {
                        bucks -= 10;
                        food += 10;
                        Console.WriteLine("Ivan купиф оливье!");
                    }
                    else
                    {
                        Console.WriteLine("*Холодильник полон*");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("У меня нет деняк(");
                }
        }
        public void Maria()
        {
            if (gaypower >= 40)
            {
                Console.Clear();
                if (gege <= 40)
                {
                    gege += 10;
                    gaypower -= 40;
                    Console.WriteLine("Ivan захватил святой Грааль и вернулся домой");
                }
                else
                {
                    Console.WriteLine("-Зачем мне куда-то идти?!");
                    Console.WriteLine("-Я что, похож на абонента?!");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Я устал(");
            }
        }
        public void Fotch()
        {
            Console.Clear();
            Console.WriteLine("Ivan нашел смешной мем XD");
            happiness += 10;
            gaypower -= 5;
            gege -= 1;
            if(happiness==100)
            {
                Console.WriteLine("Ivan вступил в срач");
                happiness -= 50;
            }
            
        }
        public void Set()
        {
            if (gege != 0)
            {
                if (gaypower != 0)
                {
                    Console.Clear();
                    Console.WriteLine("Ivan открыл Ютабчик...");
                    Console.WriteLine("Ivan ищет подходящий видос...");
                    Console.WriteLine("Ivan уже час кричит SETOOOOOOOOOOOOOOOOON...");
                    set_on += 1;
                    gaypower -= 5;
                    gege -= 5;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ivan издал последний крик в честь СЕТОНА и умер...");
                    HP = 0;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("У вас нет ГиГов.");
            }
        }
        public void Tur()
        {
            if (set_on >= 50)
            {
                int wean;
                if (set_on == 100)
                {
                    Console.Clear();
                    Console.WriteLine("Пошла жара!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("SETOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOON...");
                    Random win = new Random();
                    wean = win.Next(0, 3);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Пошла жара!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("SETOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOON...");
                    Random win = new Random();
                    wean = win.Next(0, 1);
                }
                if (wean != 0)
                {             
                    Console.WriteLine("Ivan победил в турнире и стал всемирным чемпионом СЕТОООНAA");
                    gay += 1;
                    happiness = 100;
                    
                }
                else
                {
                    Console.WriteLine("Ну блин((");
                    Console.ReadKey();
                    happiness = 0;   
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Пишов отседава!");
            }
           
        }
    }
}