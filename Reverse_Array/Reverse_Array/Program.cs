using System;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numGroup = new int[5] { 3, 6, 9, 12, 7 };

            Console.WriteLine("-------------------");
            Console.WriteLine("Intial Array");

            for (int i = 0; i < numGroup.Length; i++)
                Console.Write($"{numGroup[i]} ");

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("Press Enter to Reverse");
            Console.ReadLine();

            Reverse(numGroup);

            Console.ReadLine();
        }

        static void Reverse(int[] numArray) // Reversing the Given Arrays;
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Reversed Array");

            #region Using Array.Reverse
            //Array.Reverse(numArray);

            //for (int i = 0; i < numArray.Length; i++)
            //    Console.Write($"{numArray[i]} ");

            //Console.WriteLine();
            #endregion

            for (int i = numArray.Length - 1; i >= 0; i--)
                Console.Write($"{numArray[i]} ");

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("Press Enter to Exit");
        }
    }
}