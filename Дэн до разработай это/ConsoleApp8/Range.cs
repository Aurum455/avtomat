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
            Console.WriteLine("________________________");
            Console.WriteLine("Оружие дальнего боя    |                                             ");
            Console.WriteLine("_______________________| ___________________________________________________");
            Console.WriteLine($"Короткий Лук Охотника  || {ShortBow}       |");
            Console.WriteLine("_______________________||___________________________________________________|");
            Console.WriteLine($"Длинный Лук Леголаса   || {LongBow}   |");
            Console.WriteLine("_______________________||___________________________________________________|");
            Console.WriteLine($"Арбалет Рыцаря Лотрика || {CrossBow}                                         |");
            Console.WriteLine("_______________________||___________________________________________________|");
            Console.WriteLine($"Дротик Дикаря          ||{Javiline} |");
            Console.WriteLine("_______________________||___________________________________________________|");
        }
    }
}
