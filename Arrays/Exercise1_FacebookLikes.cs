namespace HelloWorld.Arrays
{
    public class Exercise1_FacebookLikes
    {
        public static void Run()
        {
            string nameInput;
            Console.WriteLine("Please enter the names of the users (or press Enter to finish): ");
            
            while (!string.IsNullOrWhiteSpace(nameInput = Console.ReadLine()))
            {
                var names = nameInput.Split(',');

                if (names.Length == 1)
                {
                    Console.WriteLine($"{names[0]} likes your post.");
                }
                else if (names.Length == 2)
                {
                    Console.WriteLine($"{names[0]} and {names[1]} like your post.");
                }
                else
                {
                    Console.WriteLine($"{names[0]}, {names[1]} and {names.Length - 2} others like your post.");
                }

                Console.WriteLine("Please enter the names of the users (or press Enter to finish): ");
            }

            Console.WriteLine("No more names entered. Exiting...");
        }
    }
}