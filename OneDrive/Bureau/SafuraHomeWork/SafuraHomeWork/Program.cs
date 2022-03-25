
using System;

namespace SafuraHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person("safura", 12);
            var response = person.UpperOrLower(person.Name);
            while (person.Name.Length < 3 || person.Name.Length > 30)
            {
                Console.WriteLine("Please enter your name (between 3 and 30 characters");
                person.Name = Console.ReadLine();
            }
            while (person.Surname.Length < 3 || person.Surname.Length > 35)
            {
                Console.WriteLine("Please enter your name (between 3 and 35 characters");
                person.Surname = Console.ReadLine();
            }
        }
    }
}
