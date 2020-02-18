using System;

namespace homeWorkLesson2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            for (int i = 0; i < 20; i++)
            {
                myList.Add(i + 1);

                Console.WriteLine(myList[i]);
            }

            Console.WriteLine(new string('*', 20));

            int[] test = myList.GetArray();

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }


            Console.ReadKey();
        }
    }
}
