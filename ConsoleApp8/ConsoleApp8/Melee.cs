using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Melee 
    {
        public int dva;
        public string LongSword;
        public string ShortSword;
        public string Axe;
        public string Spear;

        public Melee(string longsword, string shortsword, string axe, string spear)
        {
            this.LongSword = longsword;
            this.ShortSword = shortsword;
            this.Axe = axe;
            this.Spear = spear;
        }
        public void Print()
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("Оружие ближнего боя                                     |");
            Console.WriteLine("________________________________________________________|");
            Console.WriteLine($"Двуручный Меч Короля Артура {LongSword}|");
            Console.WriteLine("________________________________________________________|");
            Console.WriteLine($"Гладиус Центуриона {ShortSword}    |");
            Console.WriteLine("________________________________________________________|");
            Console.WriteLine($"Топор Кентавра {Axe}            |");
            Console.WriteLine("________________________________________________________|");
            Console.WriteLine($"Крылатое Копье {Spear}         |");
            Console.WriteLine("________________________________________________________|");
        }
    }
}
