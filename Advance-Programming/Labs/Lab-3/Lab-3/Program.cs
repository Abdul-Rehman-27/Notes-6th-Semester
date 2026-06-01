using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print table of 10 in reverse order
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("10 x " + i + " = " + (10 * i));
            }

            // Print factorial of 5
            int fact = 1;
            int num = 1;
            while (num <= 5)
            {
                fact *= num;
                num++;
            }
            Console.WriteLine("Factoril of " + (num - 1) + " is: " + fact);

            // Calucalte the sum of even numbers between 0 and 100
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of even numbers between 0 and 100 is:" + sum);

            // Print all those numbers between 0 and 100 that are odd and multiple of 7
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2 != 0) && (i % 7 == 0))
                {
                    Console.WriteLine("The number that are odd and divisible by 7 are: " + i);
                }
            }

            // Write a program two print any two numbers (user input)
            //int num1 = Console.ReadLine(); // give error (coz input is string and datatype of num1 is int)
            //int num2 = Console.ReadLine(); // give error (coz input is string and datatype of num1 is int)
            Console.Write("Enter number 1:");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter number 2:");
            int num2 = Convert.ToInt16(Console.ReadLine());

            int sum1 = num1 + num2;

            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is: " + sum1);


            // Print sum of even numbers of user choice
            Console.Write("Enter Starting Number:");
            int start = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Ending Number:");
            int end = Convert.ToInt16(Console.ReadLine());

            int numSum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    numSum += i;
                }
            }
            Console.WriteLine("Sum of even num between " + start + " and " + end + " is: " + numSum);

            Console.ReadKey();
        }
    }
}
