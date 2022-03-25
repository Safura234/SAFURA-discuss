using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafuraHomeWork
{
    public class Person
    {
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }

         

        public string Surname { get; set; }
        public int Age { get; set; }
        public  string UpperOrLower(string str)
        {
            return (str?.Any()).GetValueOrDefault() ? (Char.IsUpper(str.First()) ? "upper" : "lower") : "bad input";
        }

    }
}
