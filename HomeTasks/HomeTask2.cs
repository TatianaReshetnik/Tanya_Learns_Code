namespace HomeTasks;

// Write a program - a console calculator.
// Create two variables named operand1 and operand2.
// Assign arbitrary values to the variables. Prompt the user to enter the arithmetic operation sign.
// Accept the value entered by the user and place it in the string variable sign.
// To organize the choice of the computational process algorithm, use a switch statement.
// Display the result of the arithmetic operation on the screen.
// In the case of using the division operation, implement a check for an attempt to divide by zero.
// If such an attempt occurs, cancel the execution of the arithmetic operation and notify the user of the error.
internal class HomeTask2 : IBaseHomeTask
{
    public void Run()
    {
        Console.WriteLine("Enter first number");
        var firstOperand = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var secondOperand = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the function from the list: +, -, *, /");
        var function = Convert.ToChar(Console.ReadLine());
        switch (function) {
            case '+':
                var summarize = firstOperand + secondOperand;
                Console.WriteLine(summarize);
                break;

            case '-':
                var subtract = firstOperand - secondOperand;
                Console.WriteLine(subtract);
                break;

            case '*':
                var multiply = firstOperand * secondOperand;
                Console.WriteLine(multiply);
                break;

            case '/':
                if (secondOperand == 0) {
                    Console.WriteLine("Cannot divide by zero");
                }

                var divide = firstOperand / secondOperand;
                Console.WriteLine(divide);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}