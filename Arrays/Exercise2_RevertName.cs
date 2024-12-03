namespace HelloWorld.Arrays;

public class Exercise2_RevertName
{
    public static void Run()
    {
        
        Console.WriteLine("Write your name and it will be reverted.");
        string inputName = Console.ReadLine();
        char[] inputNameArr = inputName.ToCharArray();
        Array.Reverse(inputNameArr);
        Console.WriteLine(new string(inputNameArr));


    }
}