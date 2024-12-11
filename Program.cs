using System.Text;
using HelloWorld.Texts;

namespace HelloWorld
{
    partial class Program
    {
        static void Main(string[] args)
        {
         //File and FileInfo
         var path = @"c:\temp\myFile.jpg";
         File.Copy(@"c:\temp\myFile.jpg", @"d:\temp\myfile.jpg", true);
         File.Delete(path);
         if (File.Exists(path))
         {
             //
         }

         File.ReadAllText(path);
         var content = File.ReadAllBytes(path);
         var fileInfo = new FileInfo(path);
         fileInfo.CopyTo("...", true);
         fileInfo.Delete();
         if (fileInfo.Exists)
         {
             //
         }
         //fileInfo.Read is not a method
         
        }
    }
}