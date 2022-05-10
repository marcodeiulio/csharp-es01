using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            int n1, n2;

            Console.WriteLine("Insert a number");
            if (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("The inserted number is not valid;");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Insert another number");
            if (!int.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("The inserted number is not valid;");
                System.Environment.Exit(1);
            }

            Console.WriteLine("The product is {0}", Multiply(n1, n2));
        }

        static int Multiply(int n1, int n2)
        { return n1 * n2; }

    }
} // modificare il codice per richiedere alla console due numeri interi e stamparne il prodotto