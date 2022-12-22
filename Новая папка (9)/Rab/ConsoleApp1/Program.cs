using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
       static Rabotnik GetRabotnik()
        {
            Rabotnik rabotnik = new Rabotnik(1, "Martin", "Dugin", "Igorevich", "menedger", 19, 56);//,89185932343);
            
            return rabotnik;
            

        }
        static Rabotnik GetRabotnik1()
        {

            Rabotnik rabotnik1 = new Rabotnik(2, "Dima", "Slesarenok", "Alekseevich", "menedger", 18, 40);//,89185952459);

            return rabotnik1;

        }
        static Rabotnik GetRabotnik2()
        {
            Rabotnik rabotnik2 = new Rabotnik(3, "Denis", "Avhelnikov", "Aleksandrovich", "Voditel'", 29, 48);//, 89185432359);

            return rabotnik2;

        }
        static Rabotnik GetRabotnik3()
        {
            Rabotnik rabotnik3 = new Rabotnik(4, "Andrey", "Ivanov", "Ivanovuch", "Voditel'", 29, 48);//, 89185432359);

            return rabotnik3;

        }
        static Rabotnik GetRabotnik4()
        {
            Rabotnik rabotnik4 = new Rabotnik(5, "Rostislav", "Dmitrievich", "Miroshnik", "Gay'", 18, 24);//, 89185432359);

            return rabotnik4;

        }
        static Rabotnik GetRabotnik5()
        {
            Rabotnik rabotnik5 = new Rabotnik(6, "Pisun", "Igorevich", "Stein", "Nachalnik", 10, 0);//, 89185432359);

            return rabotnik5;

        }






        static void Main(string[] args)
        {
            int x,x1,y,y1;
            m1:
            Rabotnik Trabotnik = GetRabotnik();
            Rabotnik Trabotnik1 = GetRabotnik1();
            Rabotnik Trabotnik2 = GetRabotnik2();
            Rabotnik Trabotnik3 = GetRabotnik3();
            Rabotnik Trabotnik4 = GetRabotnik4();
            Rabotnik Trabotnik5 = GetRabotnik5();
 

            Console.WriteLine("Выбери доступное действие");
            Console.WriteLine("_____________________________");
            Console.WriteLine("1-Вывести всех сотрудников");
            Console.WriteLine("2-Выбрать определенного сотрудника");
            Console.WriteLine("3-Закрыть");
            x = Convert.ToInt32(Console.ReadLine());
            if (x<1 || x > 3)
            {
                Console.WriteLine("Нету такова действия");
                goto m1;
                Console.WriteLine("");
            }
            if (x == 1)
            {
                Console.WriteLine("");
                Trabotnik.Print();
                Console.WriteLine("");
                Trabotnik1.Print();
                Console.WriteLine("");
                Trabotnik2.Print();
                Console.WriteLine("");
                Trabotnik3.Print();
                Console.WriteLine("");
                Trabotnik4.Print();
                Console.WriteLine("___________________________");
                r1:
                Console.WriteLine("1-Выйти");
                Console.WriteLine("2-Назад");
                y1 = Convert.ToInt32(Console.ReadLine());
                if (y1 == 1)
                {
                    Console.ReadKey();
                }
                if (y1 == 2)
                {
                    goto m1;
                }
                else
                {
                    Console.WriteLine("Нет такова действия");
                    goto r1;
                }



            }
            if (x == 2)
            {
                t:
                Console.WriteLine("");
                Console.Write("Выбери код работника");
                Console.Write("\n1: Dugin M.I");
                Console.Write("\t\t\t2: Slesarenok D.A");
                Console.Write("\n3: Avhelnikov D.A");
                Console.Write("\t\t4: Ivanov A.I ");
                Console.Write("\n5: Miroshnik M.D");
                Console.Write("\t\t6: Stein P.I");



                Console.WriteLine("\n\t\t     7-Назад");
                x1 = Convert.ToInt32(Console.ReadLine());
                if (x1<1 || x1 > 7)
                {
                    Console.WriteLine("Таких сотрудников нету!");
                    goto t;
                }
                if (x1 == 7)
                {
                    Console.WriteLine("");
                    goto m1;
                }
                if (x1 == 1)
                {
                    Console.WriteLine("");
                    Trabotnik.Print();
                    Console.WriteLine("_________________________________");
                    rb:
                    Console.WriteLine("1-назад");
                    Console.WriteLine("2-закрыть");
                    y=Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        goto t;
                    }
                    if (y == 2)
                    {
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Нету такова действия");
                        goto rb;
                    }
                }
                if (x1 == 2)
                {
                    Console.WriteLine("");
                    Trabotnik1.Print();
                    Console.WriteLine("_________________________________");
                    rb1:
                    Console.WriteLine("1-назад");
                    Console.WriteLine("2-закрыть");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        goto t;
                    }
                    if (y == 2)
                    {
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Нету такова действия");
                        goto rb1;
                    }
                }
                if (x1 == 3)
                {
                    Console.WriteLine("");
                    Trabotnik2.Print();
                    Console.WriteLine("_________________________________");
                    rb2:
                    Console.WriteLine("1-назад");
                    Console.WriteLine("2-закрыть");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        goto t;
                    }
                    if (y == 2)
                    {
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Нету такова действия");
                        goto rb2;
                    }
                }
                if (x1 == 4)
                {
                    Console.WriteLine("");
                    Trabotnik3.Print();
                    Console.WriteLine("_________________________________");
                    rb3:
                    Console.WriteLine("1-назад");
                    Console.WriteLine("2-закрыть");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        goto t;
                    }
                    if (y == 2)
                    {
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Нету такова действия");
                        goto rb3;
                    }
                }
                if (x1 == 5)
                {
                    Console.WriteLine("");
                    Trabotnik4.Print();
                    Console.WriteLine("_________________________________");
                    rb4:
                    Console.WriteLine("1-назад");
                    Console.WriteLine("2-закрыть");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        goto t;
                    }
                    if (y == 2)
                    {
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Нету такова действия");
                        goto rb4;
                    }
                }
                if (x1 == 6)
                {
                    Console.WriteLine("");
                    Trabotnik5.Print();
                    Console.WriteLine("_________________________________");
                    rb5:
                    Console.WriteLine("1-назад");
                    Console.WriteLine("2-закрыть");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        goto t;
                    }
                    if (y == 2)
                    {
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Нету такова действия");
                        goto rb5;
                    }
                }




            }
            if (x == 3)
            {
                Console.ReadKey();
            }




        }
    }
}
