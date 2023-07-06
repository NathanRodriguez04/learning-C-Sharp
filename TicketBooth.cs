using System;

namespace vscoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Tickets are 5$. Please insert cash.");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                Console.WriteLine("Thats not enough money.");
            }
            else if (cash == 5)
            {
                Console.WriteLine("Here is your ticket>");
            }
            else
            {
                 int change = cash - 5;
                 Console.WriteLine("Here is your ticket and " + change + " Dollars in change.");
            }

            Console.ReadKey();
        }
    }
}