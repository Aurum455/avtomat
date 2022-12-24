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
            Console.WriteLine("_______________________ ");
            Console.WriteLine("Доспехи               | ");
            Console.WriteLine("______________________| ______________________________");
            Console.WriteLine($"Шлем Бебры            || {Helmet}   |"  );
            Console.WriteLine("______________________||_____________________________|");
            Console.WriteLine($"Нагрудник Саши Камня  || {Chestplate}  |");
            Console.WriteLine("______________________||_____________________________|");
            Console.WriteLine($"Поножи Спанч-Боба     || {Leggings} |");
            Console.WriteLine("______________________||_____________________________|");
            Console.WriteLine($"Сапоги Гермеса        ||{Boots}   |");
            Console.WriteLine("______________________||_____________________________|");
        }
    }
}
