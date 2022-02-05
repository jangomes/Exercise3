using System;

namespace Exercise1Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a total amount of time in minutes only: ");
            int h = Convert.ToInt32(Console.ReadLine());

            int t = h / 60;
            Console.WriteLine("It is " + t + " hour(s) and " + h%60 + "  minute(s)");
            

        }
    }
}
