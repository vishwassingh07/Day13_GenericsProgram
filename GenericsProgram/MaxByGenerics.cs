using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class MaxByGenerics<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;

        public MaxByGenerics(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static T MaximumValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine("First Value {0} is greatest of all ", firstValue);
                return firstValue;

            }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                Console.WriteLine("Second Value {0} is greatest of all ", secondValue);
                return secondValue;
            }
            else
            {
                Console.WriteLine("Third Value {0} is greatest of all ", thirdValue);
                return thirdValue;
            }

        }
        public T MaxMehod()
        {
            T Max = MaxByGenerics<T>.MaximumValue(this.firstValue, this.secondValue, this.thirdValue);
            return Max;
        }

    }
    
}
