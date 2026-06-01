using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMerging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //int[] arr3 = new int[arr1.Length + arr2.Length];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr3[i] = arr1[i];
            //}
            //for (int i = arr1.Length; i < arr3.Length; i++)
            //{
            //    arr3[i] = arr2[i-3];
            //}

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}
            //string str = "Hello";
            //Console.WriteLine(str);
            //string revStr = "";
            //for (int i = str.Length-1; i >= 0; i--)
            //{
            //    revStr += str[i];   
            //}
            //Console.WriteLine(revStr);

            int[] arr = { 1, 2, 3, 4, 5, 6, };
            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (largest < arr[i])
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine(largest);
            int sLargest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > sLargest && arr[i] < largest)
                {
                    sLargest = arr[i];
                }
            }
            Console.WriteLine(sLargest);
        }
    }
}
