// See https://aka.ms/new-console-template for more information

namespace HomeTasks
{
    internal static class HomeTasks
    {
        static int Main()
        {
            IBaseHomeTask[] homeTasks = new IBaseHomeTask[]
            {
                new HomeTask3()
            };

            Console.WriteLine("Enter home task numbers separated by commas (e.g., 1,2,3):");

            // Read the input and parse it into a list of task IDs
            var input = Console.ReadLine();
            var taskIds = input.Split(',')
                .Select(id => int.TryParse(id.Trim(), out int parsedId) ? parsedId - 1 : -1)
                .Where(id => id >= 0 && id < homeTasks.Length)
                .ToList();

            if (taskIds.Count == 0)
            {
                Console.WriteLine("No valid task numbers were entered.");
                return 1; // Exit with error code if no valid task is entered
            }

            foreach (var taskId in taskIds)
            {
                Console.WriteLine($"Running HomeTask{taskId + 1}...");
                homeTasks[taskId].Run();
            }

            return 0;
        }
    }
}


