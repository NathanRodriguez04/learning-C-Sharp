using System;

namespace vscoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;

            Console.Write("Please input age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input height (cm): ");
            height =Convert.ToInt32(Console.ReadLine());

                // && = and || = or 
            if(age >=18 && height >= 160) 
            {
                Console.WriteLine(" you can enter!");
            } else {
                Console.WriteLine("you dont meet the requirements.");
            }


            Console.ReadKey();
        }
    }
}