using System.Text;
using HelloWorld.Texts;

namespace HelloWorld
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Exercises.RunExercises();
            
            // Procedural programming
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Reversed name: " + ReverseName(name));
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--) 
                array[name.Length - i] = name[i - 1];
            var reversed = new string(array);
            
            return reversed;
        }
    }
}