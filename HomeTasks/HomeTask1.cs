using System;

namespace HomeTasks
{
    internal class HomeTask1 : IBaseHomeTask
    {
        public void Run()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}");
        }
    }
}