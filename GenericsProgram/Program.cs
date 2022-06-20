using System;
namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics Program....");
            FindMaximum findingmax = new FindMaximum();
            //findingmax.MaximumInteger(45,98,78);
            findingmax.MaximumFloat(46.66, 63.99, 146.22);
        }
    }
}