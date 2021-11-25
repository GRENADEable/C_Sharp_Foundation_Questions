using System;

namespace Palindrome_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            long  value;
            Console.WriteLine("Enter a number :");
            value = long.Parse(Console.ReadLine());

            long  temp = value;
            long  revVal = 0;
            long  remainder;

            while (temp > 0)
            {
                remainder = temp % 10;
                revVal = revVal * 10 + remainder;
                temp /= 10;
            }
            if (revVal == value)
                Console.WriteLine("Entered number is a palindrome number");
            else
                Console.WriteLine("Entered number is not a palindrome number");

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}