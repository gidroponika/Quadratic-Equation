using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    internal class Solver
    {
        private Task task;
        private int discriminant;

        public Solver(Task task) 
        { 
            this.task = task;
            discriminant = GetDiscriminant();
        }

        private int GetDiscriminant()
        {
            return (int)Math.Pow(task.B, 2)-4*task.A*task.C;
        }

        public Solution GetSolution()
        {
            Solution solution;

            if (discriminant < 0)
            {
                solution = new Solution(null,null,0);
            }
            else if(discriminant == 0)
            {
                int x1= (int)(-task.B+Math.Sqrt(discriminant)) / 2 *task.A;
                solution = new Solution(x1,null,1);
            }
            else
            {
                int x1 = (int)(-task.B + Math.Sqrt(discriminant)) / 2 * task.A;
                int x2 = (int)(-task.B - Math.Sqrt(discriminant)) / 2 * task.A;
                solution=new Solution(x1,x2,2);
            }
            return solution;
        }
    }
}
