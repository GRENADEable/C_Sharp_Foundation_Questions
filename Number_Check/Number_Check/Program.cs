using System;

namespace Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numGroup = new long[5] { 7, 1, 9, 2, 6 };
            long userNum;
            int numCount = 0;
            Console.WriteLine("Enter Number to Check");
            userNum = long.Parse(Console.ReadLine());

            // If Conditions to Compare User Entered Number with the Arrays;
            if (userNum >= numGroup[0])
                numCount++;

            if (userNum >= numGroup[1])
                numCount++;

            if (userNum >= numGroup[2])
                numCount++;

            if (userNum >= numGroup[3])
                numCount++;

            if (userNum >= numGroup[4])
                numCount++;

            Console.WriteLine($"Total Numbers Found: {numCount}");
            Console.ReadLine();
        }
    }
}