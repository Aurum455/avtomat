using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Price3
    {
        public int Price9;
        public int Price10;
        public int Price11;
        public int Price12;

        public Price3(int price9, int price10, int price11, int price12)
        {
            this.Price9 = price9;
            this.Price10 = price10;
            this.Price11 = price11;
            this.Price12 = price12;
        }
        public void Print()
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("Цена оружия дальнего боя            |");
            Console.WriteLine("____________________________________|");
            Console.WriteLine($"Короткий Лук {Price9}                    |");
            Console.WriteLine("____________________________________|");
            Console.WriteLine($"Длинный Лук {Price10}                     |");     
            Console.WriteLine("____________________________________|");
            Console.WriteLine($"Арбалет {Price11}                        |");
            Console.WriteLine("____________________________________|");
            Console.WriteLine($"Дротик (Метательное Копье){Price12}        |");
            Console.WriteLine("____________________________________|");

        }
    }
    public class Price2
    {
        public int Price5;
        public int Price6;
        public int Price7;
        public int Price8;

        public Price2(int price5, int price6, int price7, int price8)
        {

            this.Price5 = price5;
            this.Price6 = price6;
            this.Price7 = price7;
            this.Price8 = price8;
        
        }
            public void Print()
            {
                Console.WriteLine("____________________________");
                Console.WriteLine("Цена оружия ближнего боя   |");
                Console.WriteLine("___________________________|");
                Console.WriteLine($"Двуручный меч {Price5}         |");
                Console.WriteLine("___________________________|");
                Console.WriteLine($"Одноручный меч {Price6}         |");
                Console.WriteLine("___________________________|");
                Console.WriteLine($"Топор {Price7}                 |");
                Console.WriteLine("___________________________|");
                Console.WriteLine($"Копье {Price8}                  |");
                Console.WriteLine("___________________________|");
            }
        }
    }
    public class Price
    {
        public int Price1;
        public int Price2;
        public int Price3;
        public int Price4;

        public Price(int price1, int price2, int price3, int price4)
        {
            this.Price1 = price1;
            this.Price2 = price2;
            this.Price3 = price3;
            this.Price4 = price4;
            

        }

        public void Print()
        {
            Console.WriteLine("Цена доспеха       |");
            Console.WriteLine("___________________|");
            Console.WriteLine($"Шлем {Price1}           |");
            Console.WriteLine("___________________|");
            Console.WriteLine($"Нагрудник {Price2}     |");
            Console.WriteLine("___________________|");
            Console.WriteLine($"Поножи {Price3}         | ");
            Console.WriteLine("___________________|");
            Console.WriteLine($"Сапоги {Price4}         |");
            Console.WriteLine("___________________|");
        }
    }

