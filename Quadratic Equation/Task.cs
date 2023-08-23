using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    internal struct Task
    {
        public int A { get;}
        public int B { get;}
        public int C { get;}

        public Task() { }
        public Task(int a,int b,int c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
