using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In LINQ
            /** 
            1-)Data Source
            2-)Query Creation
            3-)Query Execution 
            */
            Console.WriteLine("-----------Program 1----------");
            int[] numbers = new int[6] {1, 99, 33, 55, 58, 88};
            var myQuery = from number in numbers 
                          where (number % 2) == 0 
                          select number;
       
            foreach (int num in myQuery)
            {
                Console.WriteLine("Even Numbers: " + num);
            }

            //// Dont change query or data source but print both even and odd 
            //var myQuery1 = from number in numbers
            //              where (number % 2) == 0
            //              select number;

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Find even number but greater than 50
            Console.WriteLine("----------Program-2------------");
            var myQuery1 = from num in myQuery
                           where( num >= 50 )
                           select num;
            foreach (int num in myQuery1)
            {
                Console.WriteLine("Even and > 50: " + num);
            }

            // Find even number but greater than 50 and less than 60
            Console.WriteLine("------------Program 3----------");
            var myQuery2 = from num in myQuery1
                           where (num < 60)
                           select num;
            foreach(int num in myQuery2)
            {
                Console.WriteLine("Even > 50 and < 60: " + num);
            }

            // Filter Operator
            Console.WriteLine("-------------Filer----------");
            string[] words = { "We", "all", "are", "Muslims", "Allhamdulillah" };
            IEnumerable<String> query = from word in words // IEnumerable is used when we want to perform one single operation just want to read value (no update and delete)
                                      where word.Length > 2
                                      select word;
            foreach (string word in query)
            {
                Console.WriteLine(word);
            }

            // Group Operator
            Console.WriteLine("---------Group-------------");
            List<int> nums = new List<int> { 22, 99, 0, 3, 22, 31, 100};
            IEnumerable<IGrouping<int, int>> quer = from num in nums
                                                    group num by num % 2;
            foreach (var group in quer)
            {
                Console.WriteLine(group.Key == 0 ? "Even Numbers": "Odd Numbers");
                foreach (var num in group) { 
                    Console.WriteLine(num); 
                }
            }

            // Concatination
            Console.WriteLine("-----------Concatination------------");
            char[] seq1 = { 'a', 'h', 'm', 'e', 'd' };
            char[] seq2 = { 'h', 'a', 's', 's', 'n' };
            var result = seq1.Concat(seq2);
            foreach (var value in result)
            {
                Console.WriteLine(value); 
            }

            // Sorting Opeartor
            Console.WriteLine("-----------Sorting------------");
            int[] numbs = { 1, 9, 22, 77, 33, 00, 55, 56, 23, 78, -50 };
            var sortNums = from n in numbs
                           orderby n
                           select n;
            foreach (int num in sortNums)
            {
                Console.WriteLine(num);
            }
          

            // Equality
            Console.WriteLine("------------Equality------------");
            char[] seq3 = { 'a', 'h', 'm', 'e', 'd' };
            char[] seq4 = { 'a', 'h', 'm', 'e', 'd' };
            var result1 = seq3.SequenceEqual(seq4);
            Console.WriteLine("Give sequences are equal: {0}", result1);

            // Lab Task
            Console.WriteLine("----------Lab Task--------------");
            int[] numb = new int[5] { 22, 88, 33, 77, 11 };
            var evenQuer = (from num in numb
                            where (num % 2) == 0
                            select num).ToList();
            int evenCount = evenQuer.Count();
            Console.WriteLine(evenCount);

            var oddQuery = (from num in numb
                            where (num % 2) != 0
                            select num).ToArray();
            int oddCount = oddQuery.Count();    
            Console.WriteLine(oddCount);
            Console.ReadKey();
        }
    }
}
