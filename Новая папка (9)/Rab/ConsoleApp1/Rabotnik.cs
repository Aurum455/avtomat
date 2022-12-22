using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rabotnik
    {
        
        public int id;
        public string firstName;
        public string lastName;
        public string middleName;
        public string prof;
        public int age;
        public int time;
        //public long number;

        public Rabotnik(int id, string firstName, string lastName, string middleName, string prof, int age, int time)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.prof = prof;
            this.age = age;
            this.time = time;
            //this.number = number;
        }

        public void Print()
        {
            Console.WriteLine("Информация о работнике");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Отчество: {middleName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Профессия: {prof}"); 
            Console.WriteLine($"Время работы: {time} часов ");
            //Console.WriteLine($"Телефон: {number}");
        }
    }
}
