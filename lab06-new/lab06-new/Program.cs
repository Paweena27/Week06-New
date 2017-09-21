using System;


namespace lab06_new
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 5e9d;
            Console.WriteLine(d);
            int i = checked((int)d);
            Console.WriteLine(i);

        }
    }
}
