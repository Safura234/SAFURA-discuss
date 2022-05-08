using System;

namespace negative_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 0;
            int sum = 0;
            int[] arr = new int[5];

            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of negative numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.Write(arr[i] + " ");
                Console.Write("The sum of negative input is :");
                {
                    if (arr[i] < 0)
                    {
                        sum += arr[i];

                    }
                    Console.WriteLine(sum);

                }
            }
        }
    }
}
