using System;


namespace lab06_new
{
    class Program

    {
        static void trapezoid(double E, double F, double G)
        {
            double H;
            H = (0.5 * (E + F) * G);
            Console.Write("Area of the trapzoid is : {0}", H); 
        }

        static void Main(string[] args)
        {
            double E, F, G;
            Console.Write("Enter Parallel 1");
            E = double.Parse(Console.ReadLine());
            Console.Write("Enter Parallel 2");
            F = double.Parse(Console.ReadLine());
            Console.Write("Enter high");
            G = double.Parse(Console.ReadLine());
            trapezoid(E, F, G);
            Console.ReadLine();
        }
    }
}
