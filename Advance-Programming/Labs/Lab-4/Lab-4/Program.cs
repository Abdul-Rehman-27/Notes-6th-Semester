using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------1D Array-----------------
            // type of static array (Pure Static)
            // and its only declration
            int[] arr1 = new int[6];

            // from dynamic we have created static but now not exaclty static (somehow static, somehow dynamic)  
            // declration and initialization
            int[] arr2 = new int[] {2, 3, 4, 5, 6, 7};

            // Pure dynamic
            // Initialization
            int[] arr3 = {1, 2, 3, 5, 6, 7, 8, 9, 10, 11}; // Pure dynamic 

            //--------------2D Array-----------------
            int[,] arr4 = new int[2, 3]; // Size fixed and we can't add more value
            int[,] arr5 = // size not fixed just we tell the boundary 
            {
                {1, 1, 1 },
                { 2, 2, 2 },
            };

            //--------------Jagged Array--------------
            /** 
             1- if we want multiple values at one index we used jaggged Array (similar to nested Array)
             2- At every idx in jagged array has multiple values and also has diffferent size
            */
            int[][] jaggedArr = new int[4][];
            jaggedArr[0] = new int[4] { 4, 8, 12, 16 };
            jaggedArr[1] = new int[5] { 5, 10, 15, 20, 25 };
            jaggedArr[1] = new int[6] { 6, 12, 18, 24, 30, 36 }; ;
            jaggedArr[2] = new int[7] { 7, 14, 21, 28, 35, 42, 49 }; // size of jagged Array 22

            // When jagged array become equal to jagged array
            /**
             When size at every index become equal jagged array becomes equal to 2d Array
            */

            // Print all those values in 2d Array where index sum is even
            int[,] a =
            {
            { 1, 2, 3},
            { 4, 5, 6},
            { 7, 8, 9}
        };
            Console.WriteLine("----------- Program-1 ---------------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(a[i, j] + " ");  
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            // Print all those values where index are equal 
            Console.WriteLine("-----------Program-2---------------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ( i == j)
                    {
                        Console.WriteLine(a[i, j]);
                    }
                }
            }

            Console.WriteLine("-----------Program-3---------------");
            // Print all those values where i is less than j
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        Console.WriteLine(a[i, j]);
                    }
                }
            }

            // Print all those values where i or j is equal to 0
            Console.WriteLine("-----------Program-4---------------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ( ( i == 0) || ( j == 0))
                    {
                        Console.WriteLine(a[i, j]);
                    }
                }
            }

            Console.WriteLine("-----------Program-5---------------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ( (i + j) != 2)
                    {
                        Console.WriteLine(a[i, j]);
                    }
                }
            }

            // Print all those values where i > or equal to j
            Console.WriteLine("-----------Program-6---------------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ( i >= j)
                    {
                        Console.WriteLine(a[i, j]);
                    }
                }
            }

            // Print all even numbers in 1D Array

            Console.ReadKey();
        }
    }
}
