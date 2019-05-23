using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath.Core
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Mult(int a, int b)
        {
            return a * b;
        }

        public static bool IsNegative (int a)
        {
            if (a < 0)
            {
                return true;
            }

            return false;
        }
    }
}
