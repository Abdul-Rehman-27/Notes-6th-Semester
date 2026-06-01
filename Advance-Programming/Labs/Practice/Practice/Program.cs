using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Fibbonacci Series
            Console.Write("Enter range:");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = 0;
            int num2 = 1;
            Console.Write(num1 + " ");
            Console.Write(num2 + " ");

            for (int i = 0; i <= num; i++)
            {

                int num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;

            }

            // Reverse an Array 
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Original Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.WriteLine();
            Console.WriteLine("Reverse Array");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
