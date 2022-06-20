using System;
namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics Program....");
            MaxByGenerics<int> findingmaxint = new MaxByGenerics<int>(111,22,33);
            findingmaxint.MaxMehod();
            MaxByGenerics<double> findingmaxfloat = new MaxByGenerics<double>(11.43, 43.11, 34.22);
            findingmaxfloat.MaxMehod();
            MaxByGenerics<string> findingmaxstring = new MaxByGenerics<string>("55", "34", "78");
            findingmaxstring.MaxMehod();
            Console.WriteLine("----------------------------------");
            FindMaximum maxint = new FindMaximum();
            maxint.MaximumInteger(45,98,78);
            maxint.MaximumFloat(46.66, 63.99, 146.22);
            maxint.MaximumString("45", "66", "78");
        }
    }
}