using System;

namespace CSharpQuizzes
{
    public class PostfixIncrement
    {
        public static void Run()
        {
            int[] arr = { 1, 2, 3 };
            int i = 1;
            arr[i++] = arr[i] + 10;
            Console.WriteLine(String.Join(",", arr));
        }
    }
}