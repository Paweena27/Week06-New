using System;


namespace lab06_new
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 999;
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
