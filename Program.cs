using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PP_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var factorials = new List<int>();
            var task = new Task(() =>
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
                factorials = numbers.AsParallel().Select(x => Factorial(x)).ToList();
            });
            task.Start();
            task.Wait();
            foreach (var n in factorials)
                Console.WriteLine(n);
            Console.ReadLine();
        }

        static int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал числа {x} равен {result}");
            return result;
        }
    }
}
