using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FibonacciNumber
    {
        public int Fib(int N)
        {
            // Check boundary
            if (N == 0)
                return 0;

            if (N == 1)
                return 1;

            return Fib(N - 1) + Fib(N - 2);
        }
    }
}
