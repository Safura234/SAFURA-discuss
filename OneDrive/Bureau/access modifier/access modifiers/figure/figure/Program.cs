using System;

namespace figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Calcarea = ");
            Console.WriteLine(area);
            double length, width;
            Console.WriteLine("Enter length of rectangle : ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle : ");
            width = Convert.ToDouble(Console.ReadLine());
          
        }
    }
    abstract class Figure
    {

    }
    public class Square : Figure
    {
        public void Calcarea
        {
            get { return Width; }
            set { Width = Length = value; }
        }

        public double Length { get; private set; }

        public class Rectangle
        {
            public double Width { get; set; }
            public double Length { get; set; }
            public double Area { get { return Width * Length; } }

        }
    }
}
