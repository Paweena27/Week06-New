using System;


namespace lab06_new
{
    class Program
    {
        static void Main()
        {
            int val=999; // uninitialized variable
            refMethod(ref val);
            Console.WriteLine(val);
            Console.ReadLine();
        }

        static void refMethod(ref int i)
        {
            i = i + 1;

        }
    }
}
