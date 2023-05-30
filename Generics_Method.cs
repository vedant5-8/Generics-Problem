using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Problem
{
    internal class Generics_Method
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        // To find greater valuefrom three value using Generics methods
        public T CompareALL<T>(T first, T second, T third) where T : IComparable<T>
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else
            {
                return third;
            }
            return default;
        }
    }
}
