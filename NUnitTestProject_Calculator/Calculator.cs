using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Calculator
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }
    }
}
