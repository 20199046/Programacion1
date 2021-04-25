using System;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            isoceles isoceles1 = new isoceles();
            isoceles1.height = 6;
            isoceles1.basis = 3;
            isoceles1.side = 10;

            isoceles isoceles2 = new isoceles();
            isoceles2.height = 5;
            isoceles2.basis = 2;
            isoceles2.side = 8;

            isoceles isoceles3 = new isoceles();
            isoceles3.height = 7;
            isoceles3.basis = 4;
            isoceles3.side = 11;

            isoceles1.Grow(10);
            Console.WriteLine(isoceles1.area());
            Console.WriteLine(isoceles1.perimetro());
            Console.WriteLine(isoceles2.compare(isoceles3));

            Console.ReadKey();

        }
    }
}
