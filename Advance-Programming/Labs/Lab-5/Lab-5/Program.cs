using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // List vs Array
            /**
                We can add and remove elements in list
                but in array we can just override it 

                Array is better than List
                But if we need dynamic size then list is better
            **/
            Console.WriteLine("----------Array----------");
            string[] animals = { "Cat", "Dog", "Cow", "Lion" };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("----------List Before Changes----------");
            List<string> animalList = new List<string>(animals); // we can pass whole array to list not part of it 

            foreach (var an in animalList)
            {
                Console.WriteLine(an);
            }
            Console.WriteLine("----------List After Changes----------");
            animalList.Add("Tiger");
            animalList.Remove("Dog");
            animalList.RemoveAt(3); // remove tiger
            animalList.Insert(1, "Elephent");
            Console.WriteLine(animalList.Contains("Tiger"));
            Console.WriteLine(animalList.Count);

            // Can we pass the values of array to a list?
            // Yes we can pass it
            Console.ReadKey();
        }
    }
}
