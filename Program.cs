using HelloWorld.Arrays;

namespace HelloWorld
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Quiz1_Arrays.Run();
            // Quiz2_Lists.Run();  
            // Exercise1_FacebookLikes.Run();
            // Exercise2_RevertName.Run();
            // Exercise3_UniqueNumbers.Run();
            // Exercise4_3Smallest.Run();

            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine($"Hour: {now.Hour}");
            Console.WriteLine($"Minute: {now.Minute}");
            Console.WriteLine($"Second: {now.Second}");

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            
            
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));


        }
    }
} 