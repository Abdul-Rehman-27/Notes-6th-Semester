using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            Console.WriteLine("------------------Question 01-------------------");

            string[] Names = { "Abdul Rehman", "Obaid", "Zeeshan" };

            string searchName = "Obaid";
            bool found = false;

            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == searchName)
                {
                    Console.WriteLine(searchName + " found at index: " + i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine(searchName + " not found in the array.");
            }



            // Question 2 
            Console.WriteLine("------------------Question 02-------------------");
            string[] arr = new string[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter String " + (i + 1) + ":");
                string str = Console.ReadLine();
                arr[i] = str;
            }

            Console.WriteLine("----------Array Elements-------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("String " + (i + 1) + ":" + arr[i]);
            }

            Console.WriteLine("\n----------In Upper Case--------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToUpper() + "  ");
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[(arr.Length - 1) - i];
                arr[arr.Length - 1 - i] = temp;

            }

            Console.WriteLine("\n----------Reversed Array-------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("String " + (i + 1) + ":" + arr[i]);
            }

            // Question 03
            Console.WriteLine("------------------Question 03-------------------");
            try
            {
                Console.Write("Enter a number:");
                int num = int.Parse(Console.ReadLine());
                int result = num / 0;
                Console.WriteLine("Result:" + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
