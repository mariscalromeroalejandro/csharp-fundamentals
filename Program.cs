using HelloWorld.Texts;

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

            var longSentence = " This is going to be a really really really really really long sentence.";
            var summary = StringUtility.SummarizeText(longSentence, 25);
            Console.WriteLine(summary);

        }
    }
}