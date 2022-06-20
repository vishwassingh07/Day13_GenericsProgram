using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class FindMaximum
    {
        public void MaximumInteger(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine("First Value {0} is greatest of all ", firstValue);
            }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                Console.WriteLine("Second Value {0} is greatest of all ", secondValue);
            }
            else
            {
                Console.WriteLine("Third Value {0} is greatest of all ", thirdValue);
            }

        }
        public void MaximumFloat (double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine("First Value {0} is greatest of all ", firstValue);
            }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                Console.WriteLine("Second Value {0} is greatest of all ", secondValue);
            }
            else
            {
                Console.WriteLine("Third Value {0} is greatest of all ", thirdValue);
            }

        }

    }
}
