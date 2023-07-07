using System;

namespace vscoding
{
    class Programs
    {
        static void Main(string[] args)
        {

           Console.WriteLine("How many students are in your class: ");

            int studentsCounts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the name of the students: ");

            String[] names = new string[studentsCounts];


           for (int i = 0; i < studentsCounts; i++)
           {
                names[i] = Console.ReadLine();
           }



            
           
            Console.WriteLine("\nHere they are alphabetically: ");
             Array.Sort(names);

            for (int i = 0; i < studentsCounts; i++)
           {
                Console.WriteLine(names[i]);
           }

            Console.ReadKey();
        }
    }
}