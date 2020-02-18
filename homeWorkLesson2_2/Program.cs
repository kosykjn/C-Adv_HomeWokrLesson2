using System;
using System.Collections.Generic;
using System.Linq;

namespace homeWorkLesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> test = new SortedList<int, string>();

            test.Add(9, "девять");
            test.Add(0, "ноль");
            test.Add(1, "один");           
            test.Add(6, "шесть");          
            test.Add(7, "семь");
            test.Add(2, "два");

            foreach (var item in test)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine(new string('*', 15));

            foreach (var item in test.Reverse())
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
