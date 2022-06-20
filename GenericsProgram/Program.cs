using System;
namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics Program....");
            FindMaximum<int> findingmaxint = new FindMaximum<int>();
            findingmaxint.MaximumValue(46, 98, 77);
            FindMaximum<double> findingmaxfloat = new FindMaximum<double>();
            findingmaxfloat.MaximumValue(12.32, 36.33, 41.1);
            FindMaximum<string> findingmaxstring = new FindMaximum<string>();
            findingmaxstring.MaximumValue("15", "19", "26");
            //findingmax.MaximumInteger(45,98,78);
            //findingmax.MaximumFloat(46.66, 63.99, 146.22);
            //findingmax.MaximumString("45", "66", "78");
        }
    }
}