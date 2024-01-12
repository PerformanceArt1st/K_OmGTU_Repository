using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._11._2023
{
    class Person
    {
        private string fio;
        public string Fio
        { get { return fio; } }
        private int age;
        public int Age
        { get { return age; } }
        private string educat;
        public string Educat
        { get { return educat; } }
        private string address;
        public string Address
        { get { return address; } }
        public Person(string fio, int age, string educat, string address)
        {
            this.fio = fio;
            this.age = age;
            this.educat = educat;
            this.address = address;
        }
        public new void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"ФИО: {fio}\tГод рождения: {age}\tОбразование: {educat}\tАдрес: {address} ");
            Console.WriteLine();
        }
    }
    class Programm
    {
        public static void Main()
        {
            Console.Write("Введите кол-во персон: ");
            int n = int.Parse(Console.ReadLine());
            Person[] persons = new Person[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Данныe {i + 1} персоны");
                Console.Write("ФИО: ");
                string fio = Console.ReadLine();
                Console.Write("Год рождения: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Образование: ");
                string educat = Console.ReadLine();
                Console.Write("Адрес: ");
                string address = Console.ReadLine();
                persons[i] = new Person(fio, age, educat, address);
            }
            Find_Educat(persons);
            Find_Fio(persons);
            Find_Year(persons);
        }
        static void Find_Year(Person[] array)
        {
            Console.Write("Введите год рождения для выборки: ");
            int year_find = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Age == year_find)
                {
                    count++;
                    array[i].Print();
                }
            }
            if (count == 0)
                Console.WriteLine($"Люди с {year_find} годом рождения отсуствуют в списке");
        }
        static void Find_Educat(Person[] array)
        {
            Console.Write("Введите уровень образования для выборки: ");
            string educat_find = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Educat == educat_find)
                {
                    count++;
                    array[i].Print();
                }
            }
            if (count == 0)
                Console.WriteLine($"Человек с уровнем образования *{educat_find}* отсуствует в списке");
        }
        static void Find_Fio(Person[] array)
        {
            Console.Write("Введите ФИО для выборки: ");
            string fio_find = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Fio.Contains(fio_find))
                {
                    count++;
                    array[i].Print();
                }
            }
            if (count == 0)
                Console.WriteLine($"Человек с ФИО *{fio_find}* не найден в списке");
            Console.WriteLine();
        }
    }

}
