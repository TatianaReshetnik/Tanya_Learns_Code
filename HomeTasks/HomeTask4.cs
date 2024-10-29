namespace HomeTasks;
//Task 3
// Write a Russian-English translator program. The program knows 10 weather-related words.
// It is required that the user enters a word in Russian, and the program provides the translation of that word into English.
// If the user enters a word for which there is no translation, display a message that such a word does not exist.

public class HomeTask4 : IBaseHomeTask
{
    public void Run()
    {
        Console.WriteLine(
            "Enter any of the following words: тепло, дождь, туман, солнце, ясно, небо, облако, вода, снег, жара");
        var weatherWord = Console.ReadLine();
        switch (weatherWord) {
            case "тепло":
                Console.WriteLine("warm");
                break;

            case "дождь":
                Console.WriteLine("rain");
                break;
            case "туман":
                Console.WriteLine("fog");
                break;
            case "солнце":
                Console.WriteLine("sun");
                break;
            case "ясно":
                Console.WriteLine("clear");
                break;
            case "небо":
                Console.WriteLine("sky");
                break;
            case "облако":
                Console.WriteLine("cloud");
                break;
            case "вода":
                Console.WriteLine("water");
                break;
            case "снег":
                Console.WriteLine("snow");
                break;
            case "жара":
                Console.WriteLine("heat");
                break;
            default:
                Console.WriteLine("Неверное слово");
                break;
        }
    }
}