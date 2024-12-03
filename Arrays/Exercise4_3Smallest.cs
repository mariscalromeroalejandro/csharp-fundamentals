namespace HelloWorld.Arrays;

public class Exercise4_3Smallest
{
    public static void Run()
    {
        Console.WriteLine("Supply a list of comma separated numbers (5 or more):");
        var inputArr = Console.ReadLine().Split(",");
        if (inputArr.Length < 5)
        {
            Console.WriteLine("Invalid list. Try again.");
        }
        else
        {
            var list = new List<int>();
            foreach (var number in inputArr)
            {
                list.Add(int.Parse(number));
                list.Sort();
            }
            Console.WriteLine($"The 3 smallest numbers are:\n");
            Console.WriteLine(string.Join(", ", list.Take(3)));
            
        }
    }
}