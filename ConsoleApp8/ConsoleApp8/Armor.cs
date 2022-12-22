using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Armor
    {
        public int perviy;
        public string Helmet;
        public string Chestplate;
        public string Leggings;
        public string Boots;

        public Armor(string helmet, string chestplate, string leggings, string boots)
        {
            this.Helmet = helmet;
            this.Chestplate = chestplate;
            this.Leggings = leggings;
            this.Boots = boots;

        }

        public void Print()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Доспехи                                         |");
            Console.WriteLine("________________________________________________|");
            Console.WriteLine($"Шлем Бебры {Helmet}            |"  );
            Console.WriteLine("________________________________________________|");
            Console.WriteLine($"Нагрудник Саши Камня {Chestplate} |");
            Console.WriteLine("________________________________________________|");
            Console.WriteLine($"Поножи Спанч-Боба {Leggings}   |");
            Console.WriteLine("________________________________________________|");
            Console.WriteLine($"Сапоги Гермеса {Boots}       |");
            Console.WriteLine("________________________________________________|");
        }
    }
}
