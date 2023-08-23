using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    internal struct Solution
    {
        public readonly int? X1;
        public readonly int? X2;
        public readonly int CountSolution;

        public Solution()
        {
            X1 = null;
            X2 = null;
            CountSolution = 0;
        }

        public Solution(int? x1, int? x2, int countSolution)
        {
            X1 = x1;
            X2 = x2;
            CountSolution = countSolution;
        }
    }
}
