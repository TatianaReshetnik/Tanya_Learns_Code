namespace HomeTasks;
// Create an array of integers. Write a program that displays a message indicating whether a specified number is in the array or not.
// Let the number to be searched be entered from the console.

public class HomeTask8 : IBaseHomeTask
{
    public void Run()
    {
        int[] Array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        Console.WriteLine("Enter your number");
        int input = int.Parse(Console.ReadLine());
        for (int i = 0; i < Array.Length; i++)
            if (Array[i] == input)
                Console.WriteLine("Your number is in the array");
    }
}

    