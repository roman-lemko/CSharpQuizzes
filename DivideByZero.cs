using System;

namespace CSharpQuizzes
{
    public class DivideByZero
    {
        public static void Run()
        {
            float dividend = 56, divisor = 0;
            try
            {
                Console.WriteLine(dividend / divisor);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division By Zero");
            }
        }
    }
}