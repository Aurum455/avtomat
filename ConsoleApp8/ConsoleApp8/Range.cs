using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Range
    {
        public string ShortBow;
        public string LongBow;
        public string CrossBow;
        public string Javiline;

        public Range(string shortBow, string longBow, string crossBow, string javiline)
        {
            this.ShortBow = shortBow;
            this.LongBow = longBow;
            this.CrossBow = crossBow;
            this.Javiline = javiline;
        }

        public void Print() {
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("Оружие дальнего боя                                                 |");
            Console.WriteLine("____________________________________________________________________|");
            Console.WriteLine($"Короткий Лук Охотника {ShortBow}   |");
            Console.WriteLine("____________________________________________________________________|");
            Console.WriteLine($"Длинный Лук Леголаса {LongBow}|");
            Console.WriteLine("____________________________________________________________________|");
            Console.WriteLine($"Арбалет Рыцаря Лотрика {CrossBow}                                    |");
            Console.WriteLine("____________________________________________________________________|");
            Console.WriteLine($"Дротик Дикаря {Javiline}    |");
            Console.WriteLine("____________________________________________________________________|");
        }
    }
}
