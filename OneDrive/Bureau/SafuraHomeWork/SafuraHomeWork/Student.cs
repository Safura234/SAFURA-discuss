using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafuraHomeWork
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }
        private int size;
        public int Point
        {
            get { return size.FixedValue(1, 100); }
            set { size = value.FixedValue(1, 100); }
        }
    }
}
