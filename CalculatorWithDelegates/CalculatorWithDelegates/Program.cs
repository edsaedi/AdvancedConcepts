using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorWithDelegates
{
    class Program
    {
        //public delegate float MathOperation(float num1, float num2);

        public static float Add(float a, float b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            var operations = new Dictionary<char, Func<float, float, float>>();

            //operations.Add('+', (x, y) => { return x + y; });
            operations.Add('+', Add);
            operations.Add('-', (x, y) => x - y);
            operations.Add('*', (x, y) => { return x * y; });
            operations.Add('/', (x, y) => { return x / y; });
            operations.Add('%', (x, y) => { return x % y; });
            operations.Add('^', (x, y) => { return (float)Math.Pow(x, y); });

            Console.WriteLine("Enter in two numbers!");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter in an operation sign!");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(operations[operation].Invoke(a, b));

            //MathOperation math = Add;
            //float z = math(5, 10);
            //z = math.Invoke(6, 10);
        }
    }
}
