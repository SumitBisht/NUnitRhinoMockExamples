using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTesting.src
{
    class MyClass
    {
        /// <summary>
        /// A simple addition method that adds its arguments and returns the added value
        /// </summary>
        public static int add(int argA, int argB)
        {
            return argA + argB;
        }

        /// <summary>
        /// This is a recursive method call to find the factorial of the number that is passed into the function.
        /// For zero and negative numbers, no such operation is carried out
        /// </summary>
        /// <param name="arg">The number whose factorial is to be obtained</param>
        /// <returns>The resultant value of the factorial</returns>
        public static long factorial(long arg)
        {
            if( arg <=1 )
            {
                return 1;
            }
            return arg*factorial(arg - 1);
        }
    }
}
