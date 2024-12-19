namespace HomeTasks;
//Iterating Through Multidimensional Arrays Task

public class HomeTask7 : IBaseHomeTask
{
    public void Run()
    {
        int rows = 3;
        int columns = 3;
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                Console.Write($"Enter value for matrix[{i},{j}]: ");
                string input = Console.ReadLine();
                matrix[i, j] = int.Parse(input);
            }
        }

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine(); // Move to the next line after printing one row
        }
        
        int max = matrix[0, 0];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                if (matrix[i, j] > max) {
                    max = matrix[i, j];
                }
            }
        }

        Console.WriteLine("The maximum value in the matrix is: " + max);

        int sum1 = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
        Console.WriteLine("Sum on the primary diagonal = " + sum1);
        
        int sum2 = matrix[0, 2] + matrix[1, 1] + matrix[2, 0];
        Console.WriteLine("Sum on the secondary diagonal = " + sum2);
    }
}