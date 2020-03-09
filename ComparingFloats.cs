using System;

namespace CSharpQuizzes
{
    public class ComparingFloats
    {
        public static void Run()
        {
            double num1 = 1.000001;
            double num2 = 0.000001;
            Console.WriteLine((num1 - num2) == 1.0);
        }
    }
}