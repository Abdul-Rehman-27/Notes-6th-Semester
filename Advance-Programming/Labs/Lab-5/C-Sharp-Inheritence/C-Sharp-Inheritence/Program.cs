using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Inheritence
{
    internal class Program
    {
        class Name
        {
            public Name() {
                Console.WriteLine("This is the Parent Class");
            }
            
            public Name(int id)
            {
                Console.WriteLine("Parameterized Constructor of Parent Class");
                Console.WriteLine("Parameterized Constructor of Parent Class");
                Console.WriteLine("Parameterized Constructor of Parent Class");
            }
            public void func_1()
            {
                Console.WriteLine("This is the body of function");
            }
            
        }

        class program : Name   // ( : mean extend) | program (Child Classs) | Name (Parent Class)
        {

        }
        static void Main(string[] args)
        {
            Name obj1 = new Name(1); // overloading: don't go to Name() go to Name(int id)
            obj1.func_1();

            // Static
            /** 
                When we don't want to call any (parametrize, default) constructor of class
            **/
        }
    }
}
