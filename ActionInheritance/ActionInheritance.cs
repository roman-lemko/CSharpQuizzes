using System;


namespace CSharpQuizzes
{
    class Base
    {
    }

    class Derived : Base
    {
    }

    public class ActionInheritance
    {
        public static void Run()
        {
            Action<Base> b = (target) => { Console.WriteLine(target.GetType().Name); };
            Action<Derived> d = b;
            d(new Derived());
        }
    }
}