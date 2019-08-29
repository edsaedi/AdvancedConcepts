using System;

namespace Delegates
{

    enum MessageType
    {
        Sucess,
        Fail,
        Info
    }


    class Program
    {


        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        static int Divide(int num1, int num2) => (num1 / num2);

        static int Sub(int num1, int num2) => (num1 - num2);


        delegate int MathFunc(int a, int b);
        static MathFunc currentFunction;

        static void PrintAnswer(MathFunc func, int num1, int num2)
        {
            Console.WriteLine(func(num1, num2));
        }

        delegate void Message(string msg, MessageType type);
        static Message message;



        static void Main(string[] args)
        {
            Console.WriteLine($"Enter two numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pick an opreation");
            string op = Console.ReadLine();





            if (op == "+")
            {
                currentFunction = Add;
            }
            else if (op == "*")
            {
                currentFunction = (x, y) => (x * y);
            }






        }
    }
}
