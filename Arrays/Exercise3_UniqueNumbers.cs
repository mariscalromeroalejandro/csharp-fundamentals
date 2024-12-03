namespace HelloWorld.Arrays;

public class Exercise3_UniqueNumbers
{
    public static void Run()
    {

        var numbersList = new List<int>();
        while (numbersList.Count < 5)
        {
            Console.Write($"Enter number ({5 - numbersList.Count} numbers left): ");
            var input = Convert.ToInt32(Console.ReadLine());
            if (!numbersList.Contains(input))
            {
                numbersList.Add(input);
            }
            else
            {
                Console.WriteLine($"Number {input} is already in the list");
            }
        }

        var result = String.Join(", ", numbersList.ToArray());
        Console.WriteLine($"Unique numbers entered: {result}");
    }
}