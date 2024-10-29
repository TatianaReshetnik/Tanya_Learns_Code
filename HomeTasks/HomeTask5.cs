namespace HomeTasks;
// Write a program that will perform a check for even numbers. Propose two solutions to the given task.

public class HomeTask5 : IBaseHomeTask
{
    public void Run()
    {
        Console.WriteLine("Enter any number");
        var number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }
}