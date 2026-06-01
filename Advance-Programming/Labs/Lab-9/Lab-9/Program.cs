using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------Write into File----------------
            string text = "my Name is Abdul-Rehman.";
            string path = @"C:\Users\HEC\Documents\6th Semester\AP\Labs\Lab-9\myTxt.txt"; // We store path in a variable because we can use it multiple times.
            // @ : consider single backslash as double backslash in path
            File.WriteAllText(path, text);   // WriteAllText(): Create file if not exist and also write into it.

            //--------------Read from File----------------
            string read = File.ReadAllText(path);    // ReadAllText(): Read all text from file and return it as string. (In ReadAllText() file must already exist)
            Console.WriteLine("File Content:");
            Console.WriteLine(read);

            //--------------Append text into file----------------
            string appendTxt = "I am 21 Years Old.";
            File.AppendAllText(path, appendTxt);   // AppendAllText(): Append text into file. (In AppendAllText() file must already exist)

            //--------------Read from File----------------
            //Read again after append
            string updatedText = File.ReadAllText(path);
            Console.WriteLine("\nAfter Append:");
            Console.WriteLine(updatedText);

            //--------------Copy file----------------
            string copyPath = @"C:\Users\HEC\Documents\6th Semester\AP\Labs\Lab-9\myTxtCopy.txt";
            File.Copy(path, copyPath, true);   // Copy(): Copy file from source to destination. (In Copy() source file must already exist) (true: overwrite if destination file already exists)

            string copiedText = File.ReadAllText(copyPath);
            Console.WriteLine("\nCopied File Content:");
            Console.WriteLine(copiedText);

            //---------------Empty old file--------------
            string emptyText = "";
            // @ : consider single backslash as double backslash in path
            File.WriteAllText(path, emptyText);   // WriteAllText(): Create file if not exist and also write into it.

            // After emptying the file, read it again
            Console.WriteLine("File Content After Empty:");
            string readEmpty = File.ReadAllText(path);
            Console.WriteLine(readEmpty);

            //---------------Delete file------------------
            File.Delete(path);

            //--------------Check if file exists----------------
            if (File.Exists(path))
            {
                Console.WriteLine("\nFile exists.");
            }
            else
            {
                Console.WriteLine("\nFile does not exist.");
            }

            ////--------------Write user input into file and read it----------------
            //Console.Write("Enter text to write into file: ");
            //string userInput = Console.ReadLine();
            //string newPath = "C:\\Users\\HEC\\Documents\\6th Semester\\AP\\Labs\\Lab-9\\userInput.txt";
            //File.WriteAllText(newPath, userInput);   // Write user input into file

            //string textFromFile = File.ReadAllText(newPath); 
            //Console.WriteLine(textFromFile);

           

            Console.ReadKey();
        }
    }
}
