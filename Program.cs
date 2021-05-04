using System;

namespace firstC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, how are you?");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, nice to meet you. My name is Console. I'm going to kill you.");
        }
    }
}
