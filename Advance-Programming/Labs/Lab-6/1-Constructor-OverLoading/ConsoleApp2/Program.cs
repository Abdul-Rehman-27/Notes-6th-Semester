using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        String name;
        // Consutrucotr has no link with inheritence it has link with class and object creation
        // Consturctor has no return type unlike function 

        // Default Constructor
        public Program()
        {
            Console.WriteLine("Body of default constructor");
        }

        // Parametrize Constructor 
        public Program(string name)
        {
            this.name = name;
        }

        // Function Overloading

        public void printName()
        {
            Console.WriteLine("Abdul-Rehman");
        }

        public void printName(string name)
        {
            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            Program p1 = new Program(); // object is a medium to access class 

            Program p2 = new Program("Comsats"); // Parametrize Constructor
            p2.printName();     // func without  params | output: Abdul-Rehman
            p2.printName("Muhammad");   // func with params  | output: Muhammad
            Console.WriteLine(p2.name); // output: Comsats

            Console.Write("Enter Name:");
            string userInput = Console.ReadLine();
            Program p3 = new Program(userInput);
            Console.WriteLine("Your Name is " + p3.name);  // output: User Input 




            Console.ReadKey();
        }
    }
}
