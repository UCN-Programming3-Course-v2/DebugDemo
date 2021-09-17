using BuggedLibrary;
using System;

namespace DebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Who do you wanna say hello to? -> ");
            string input = Console.ReadLine();

            NiceGreeter greeter = new NiceGreeter();

            string greeting = greeter.SayHello(input);

            Console.WriteLine(greeting);
        }
    }
}
