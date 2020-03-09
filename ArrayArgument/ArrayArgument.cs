using System;

namespace CSharpQuizzes
{
    public static class ArrayArgument
    {
        static void ModifyArray(int[] a)
        {
            int[] b = new int[5];
            a = b;
        }

        public static void Run()
        {
            int[] arr = new int[10];
            ModifyArray(arr);
            Console.WriteLine(arr.Length);
        }
    }
}