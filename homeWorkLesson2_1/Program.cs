using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            for (int i = 0; i <= 20; i++)
            {
                myList.Add(i + 2);

                Console.WriteLine(myList[i]);
            }

            Console.WriteLine(new string('*',20));

            int[] test = myList.GetArray();

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }           
            

            Console.ReadKey();
        }
    }
}
