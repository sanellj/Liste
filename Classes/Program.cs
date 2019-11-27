using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liste
            Liste();
            Console.ReadKey();
        }

        static void Liste()
        {
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(25);
            numbers.Add(39);
            numbers.Add(2);
            numbers.Add(7);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            numbers.Sort();

            Console.WriteLine("After calling Sort() method");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
