namespace HomeTasks;
// Write a program that will perform a check for even numbers. Propose two solutions to the given task.

public class HomeTask6 : IBaseHomeTask
{
    public void Run()
    {
        Console.WriteLine("Enter any number");
        var number = int.Parse(Console.ReadLine());
        var result = number % 2 == 0 ? "Number is even" : "Number is odd";
        Console.WriteLine(result);
    }
}