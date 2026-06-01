using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;        // variable occupies space in memory
            //Console.Write(a);  // error: coz we have not assigned any value to a, b and c
            a = 10;
            b = 2;
            c = 3;
            Console.Write(a);
            Console.Write("{0}", a);
            Console.Write("{}{}");
            Console.WriteLine("" + a); // Operator Overloading

            // Swapping Program Using 3rd Variable
            Console.WriteLine("------Before Swap------");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            int d = a;
            a = b;
            b = d;
            Console.WriteLine("------After Swap-------");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            // Swapping Porgram Using only two variable
            int r = 14;
            int m = 12;
            Console.WriteLine("------Before Swap------");
            Console.WriteLine("r = " + r);
            Console.WriteLine("m = " + m);
            r = r - m;
            m = r + m;
            r = m - r;
            Console.WriteLine("------After Swap-------");
            Console.WriteLine("r = " + r);
            Console.WriteLine("m = " + m);


            // Number Checker Program 
            Console.WriteLine("--------Number Check----------");
            int x = 5;
            int y = 7;
            if (a > b)
            {
                Console.WriteLine(x * x);
            } else if ( x < y)
            {
                Console.WriteLine(x * x * x);
            } else
            {
                x = y = 0;
                Console.WriteLine("a={0} b={1}", x, y);
            }

            // Celsius to Fahrenheit
            Console.WriteLine("----------Temprature Convertor--------------");
            float celsius = 43;
            float f = (celsius * 9f / 5f) + 32;
            Console.WriteLine($"Temperature {celsius}°C in Fahrenheit is {f}°F");

            // Print the series 1, 0, 2, 100, 3, 200, 4, 300, 5, 400 using two variable
            Console.WriteLine("-------------Series-1---------------");
            int num1 = 1;
            int num2 = 0;
            while (num1 < 5)
            {
                Console.Write("{0} {1} ", num1, num2);
                num1 = num1 + 1;
                num2 = num2 + 100;
            }

            // print the series a, 1, 10, a, 2, 20, a, 3, 30, a, 4, 40 using one variable
            Console.WriteLine();
            Console.WriteLine("-------------Series-2---------------");
            for (int num3 = 1; num3 <= 4; num3++)
            {
                Console.Write("a {0} {1} ", num3, num3 * 10);
            }

             Console.ReadKey();
        }
    }
}
