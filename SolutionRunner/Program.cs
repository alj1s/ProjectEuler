using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Problems;

namespace SolutionRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Start();
                }
                else
                {
                    int problem;
                    if (int.TryParse(args[0], out problem))
                    {
                        RunSolver(problem);
                    }
                    else
                    {
                        Start();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured:");
                Console.WriteLine();
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Start(false);
            }
        }

        private static void Start(bool firstRun = true)
        {
            int problem;
            if (firstRun)
                Console.WriteLine("Welcome to the ProjectEuler solver program");

            Console.WriteLine("Please enter the problem number:");


            while (!int.TryParse(Console.ReadLine(), out problem))
            {
                Console.WriteLine("Could not read the problem number. Please try again:");
                Console.WriteLine("Please enter the problem number:");
            }

            RunSolver(problem);
        }

        private static void RunSolver(int problemNumber)
        {
            Console.WriteLine("Calculating...");
            var stopwatch = Stopwatch.StartNew();
            var problem = FindProblem(problemNumber);
            var answer = problem.Solve();

            Console.WriteLine(answer);
            Console.WriteLine();
            Console.Write("Calculation took {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine();
            Console.WriteLine();

            Start(false);
        }

        private static IProblem FindProblem(int problemNumber)
        {
            var typeName = "Problem" + problemNumber;
            var assembly = Assembly.Load("Problems");
            var types = assembly.GetTypes();
            var problemType = types.Single(t => t.Name == typeName);
            dynamic problem = Activator.CreateInstance(problemType);

            return problem as IProblem;

        }
    }
}
