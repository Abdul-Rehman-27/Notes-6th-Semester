using System;

namespace Lab_7
{
    internal class Program
    {
        //// Divide by Zero Exception 
        //static double checkDivision(double x, double y)
        //{
        //    if (y == 0)
        //        throw new System.DivideByZeroException();

        //    return x / y;
        //}

        // Sqrt of number Program 
        static double checkSqrt(double x)
        {
            if (x < 0)
                throw new System.FormatException("Negative number is not allowed");
            return Math.Sqrt(x);
        }
        static void Main(string[] args)
        {
            // Error: Voilation of rules of any language
            // Warning: Indication 
            // Exception: Not expected (variable named age and u want age in number like 20 year but user enter "twenty" (tpye mismatch) this is where exception comes in 
            // Try can only be one in program but catch can be one or more
            // 1-Format Exception 2-System Divide by zero exception 3-Overflow excpetion 

            //double num1 = 100;
            //double num2 = 0;
            //double result = 0;
            //try
            //{
            //    //result = checkDivision(num1, num2);
            //    if (num2 == 0)
            //        throw new System.DivideByZeroException();


            //    result = num1 / num2;
            //    Console.WriteLine("{0} divide by {1} = {2}", num1, num2, result);

            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Trying to divide by zero: " + ex.Message);
            //}

            try
            {

                Console.WriteLine(checkSqrt(-1));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Negative not allowed:" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
