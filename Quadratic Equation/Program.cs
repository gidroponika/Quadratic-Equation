namespace Quadratic_Equation
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter A number ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B number ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter C number ");
            int c = Convert.ToInt32(Console.ReadLine());

            Task task=new Task(a, b, c);
            Solver solver = new Solver(task);
            Solution solution = solver.GetSolution();

            Console.WriteLine();
            Console.WriteLine($"This quadratic equation has {solution.CountSolution} decision");
            Console.WriteLine(solution.X1);
            Console.WriteLine(solution.X2);
        }
    }
}