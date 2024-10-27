namespace HomeTasks;
//Write a program to determine whether the number specified by the user from 0 to 100 falls within the numerical range 
//[0 - 14] [15 - 35] [36 - 50] [51 - 100]. If yes, indicate in which specific range. 
//If the user specifies a number that does not belong to any of the existing numerical ranges, display the corresponding message.
public class HomeTask3 : IBaseHomeTask
{
    public void Run()
    {
        Console.WriteLine("Enter any number from 0 to 100");
        var number = int.Parse(Console.ReadLine());
        if (number >= 0 && number <=14) Console.WriteLine("Your number is within range 0-14");
        else if (number > 14 && number <= 35) Console.WriteLine("Your number is within range 15-35"); 
        else if (number >35 && number <= 50) Console.WriteLine("Your number is within range 36-50");
        else if (number>50 && number <=100) Console.WriteLine("Your number is within range 51-100");
        else Console.WriteLine("Your number is NOT within range 0-100");


    }
}