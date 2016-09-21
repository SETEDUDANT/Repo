using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMath
{
    public class Class1
    {

    }

    public class MyMath
    {
        public double Pi = 1.132434;
        /// <summary>
        /// Add the two given numbers
        /// </summary>
        /// <param name="first">The first numer to add</param>
        /// <param name="second">The second number to add</param>
        /// <returns>Addition of both</returns>
        public int add(int first, int second)
        {
            return first + second;
        }

        public int multiply(int first, int second)
        {
            return first * second;
        }
    }

}
