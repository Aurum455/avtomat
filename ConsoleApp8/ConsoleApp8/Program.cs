using System;
namespace ConsoleApp8
{

    class Fantasy_Shop
    {

        private static Armor GetArmor() {
            Armor Armor = new Armor ("Защита 10 + 50 к обонянию", "Защита 20 + 40 к живучести", "Защита 15 + 10 к плавучести", " Защита 5 + 20 к скорости ");

            return Armor;
        }
        private static Melee GetMelee()
        {
            Melee Melee = new Melee("Атака 30 + 10 к урону светом", "Атака 15 + 20 урона кровотечением", "Атака 35 + 10 к телосложению ", " Атака 10 + 20 к скорости атаки ");

            return Melee;
        }
        private static Range GetRange()
        {
            Range Range = new Range("Атака 10 + 20 к скорости натягивания тетевы", "Атака 20 + 20 урона по легкобронированным целям", "Атака 30 ", " Атака 10 - 5 урона по тяжелоброннированным целям ");

            return Range;
        }
        private static Price GetPrice()
        {
            Price Price = new Price( 500, 1000, 700 ,400);

            return Price;
        }

        private static Price2 GetPrice2()
        {
            Price2 Price2 = new Price2( 1000, 750, 1000, 400);

            return Price2;
        }

        private static Price3 GetPrice3()
        {
            Price3 Price3 = new Price3(300, 600, 1000, 50);

            return Price3;
        }
        private static void Main(string[] args)
           
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("Выбери вид товара             |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("1-Доспехи                     |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("2-Оружие ближнего боя         |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("3-Оружие дальнего боя         |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("4-Закрыть                     |");
            Console.WriteLine("______________________________|");

            Armor armor = GetArmor();

            Price price = GetPrice();

            Melee melee = GetMelee();

            Price2 price2 = GetPrice2();

            Range range= GetRange();

            Price3 price3 = GetPrice3();
            int a, b, c;

            a = Convert.ToInt32(Console.ReadLine());
            if (a < 1 || a > 4) {
                Console.WriteLine("Такое действие отсутствует");


            }
            if (a == 1)
                {
                armor.Print();
                price.Print();
            }

            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b < 1 || b > 4)
                {
                    Console.WriteLine("Такое действие отсутствует");
                }
                if (b == 2)
                {
                    melee.Print();
                    price2.Print();

                }


            }

            {
                c = Convert.ToInt32(Console.ReadLine());
                if (c < 1 || c > 4)
                {
                    Console.WriteLine("Такое действие отсутствует");
                }
                if (c == 3)
                {
                    range.Print();
                    price3.Print();

                }
            }

        }
    }
}