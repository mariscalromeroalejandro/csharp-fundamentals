using System.Globalization;

namespace HelloWorld.Texts;
using System.Text; 

public class Exercises
{
    public static void RunExercises()
    {
        // AreConsecutive();
        // areDuplicatedsHere();
        // validTimeExervise();
    }

    static void AreConsecutive()
    {
        Console.WriteLine("Enter a few numbers separated by a hyphen:");
        var numbers = Console.ReadLine().Split("-").Select(int.Parse).ToArray();

        var result = new StringBuilder();
        result.Append("Processing numbers: ");
        result.Append(string.Join(", ", numbers));
        result.AppendLine();

        bool areConsecutive = true;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != numbers[i - 1] + 1)
            {
                areConsecutive = false;
                break;
            }
        }

        if (areConsecutive)
            result.AppendLine("The numbers are consecutive.");
        else
            result.AppendLine("The numbers are not consecutive.");

        Console.WriteLine(result.ToString());
    }

    static void areDuplicatedsHere()
    {
        Console.WriteLine("Enter a few numbers separeted by a hyphen");
        var numbers = Console.ReadLine().Split("-").Select(int.Parse).ToList();
            var result = new StringBuilder();
        if (numbers.Count == 0)
        {
            result.Append("Exiting the exercise.");
        }
        else
        {
            result.Append("Processing numbers: ");
            result.Append(string.Join(", ", numbers));
            result.AppendLine();
            var newList = numbers.Distinct().ToList();
            if (newList.Count ==  numbers.Count)
            {
                result.AppendLine("There are no duplicate numbers.");
            }
            else
            {
                result.AppendLine("The numbers are duplicated.");
            }
        }
        Console.WriteLine(result.ToString());

    }

    static void validTimeExervise()
    {
        Console.Write("Enter a time in 24-hour format (HH:mm): ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid Time");
            return;
        }

        if (TimeOnly.TryParse(input, out TimeOnly time))
        {
            if (time >= TimeOnly.MinValue && time <= TimeOnly.MaxValue)
            {
                Console.WriteLine("The time is OK.");
                return;
            }
            Console.WriteLine("Invalid Time. Try Again");
        }
        else
        {
            Console.WriteLine("Invalid Time. Try Again");
        }
    }
    
    
}