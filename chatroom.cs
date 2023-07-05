using System;

namespace vscoding 
{
    class chatroom
    {
        static void Main(string[] args)
        {
            // change the appearance
            Console.Title = "skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            // get a coversation going 
            Console.WriteLine("hello, what's your name?");

            Console.ReadLine();

            Console.WriteLine("my name is Chad Mcchader i am from the future.");
            Console.WriteLine("whats is your favorite color?");

            Console.ReadLine();

            Console.WriteLine("my is green");
            // wait before closing
            Console.ReadKey();
        }
    }
}