using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            Console.WriteLine("Insert a number");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert another number");
            int n2 = int.Parse(Console.ReadLine());

            int prod = n1 * n2;

            Console.WriteLine("The product is {0}", Multiply(n1, n2));
        }

        static int Multiply(int n1, int n2)
        { return n1 * n2; }

    }
} // modificare il codice per richiedere alla console due numeri interi e stamparne il prodotto