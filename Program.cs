using System.Text;
using HelloWorld.Texts;

namespace HelloWorld
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var path = @"..\..\..\..\HelloWorld\HelloWorld.txt";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));
        }
    }
}