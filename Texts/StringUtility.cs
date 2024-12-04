namespace HelloWorld.Texts;

public class StringUtility
{
    public static string SummarizeText(string text, int maxLength)
    {

        if (text.Length < maxLength)
        {
            return text;
        }

        else
        {
            text.Substring(0, maxLength);
            var words = text.Split(' ');
            var totalCharacter = 0;
            var summaryWords = new List<string>();
            
            foreach (var word in words)
            {
                summaryWords.Add(word);
                
                totalCharacter += word.Length + 1;
                if (totalCharacter > maxLength)
                {
                    break;
                }
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}