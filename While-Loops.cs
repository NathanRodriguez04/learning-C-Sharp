using System;

namespace vscoding
{
    class Programs
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll01 = 0;
            int roll02 = 1;
            int attempts = 0;

            Console.WriteLine(" press any key to roll the die.");

            while (roll01 != roll02)
            {
                Console.ReadKey();

                roll01 = numberGen.Next(1, 7);
                roll01 = numberGen.Next(1, 7);

                Console.WriteLine("Roll01: " + roll01);
                Console.WriteLine(" Roll02: " + roll02 + "\n");

                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll tow of a kind.");


            Console.ReadKey();
        }
    }
}