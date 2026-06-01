using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Constructor_Chaining
{
    class A
    {
        public A()
        {
            Console.WriteLine("Constructor A");
        }
    }

    class B : A
    {
       public B()
        {
            Console.WriteLine("Constructor B");
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine("Constructor C");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            B b = new B();
            Console.ReadKey();
        }
    }
}
