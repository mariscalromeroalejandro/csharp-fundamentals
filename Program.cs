using System.Text;
using HelloWorld.Texts;

namespace HelloWorld
{
    partial class Program
    {
        static void Main(string[] args)
        {
         
            // Directory and directoryInfo
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\projects\fundamentals", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);
            var directories = Directory.GetDirectories(@"c:\projects\fundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);
            Directory.Exists("...");
            
            var directoryInfo = new DirectoryInfo(@"...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
            
            
        }
    }
}