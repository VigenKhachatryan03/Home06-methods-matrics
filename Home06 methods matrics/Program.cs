using System;

namespace Home06_methods_matrics
{
    class Program
    {
        static int[,] Matrix(int n, int a, int b)
        {
            int[,] Matrix = new int[n, n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matrix[i, j] = r.Next(a, b);
                }
            }
            return Matrix;
        }
        static void PrintMatrix(int[,] Matrix)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (i > j)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.ResetColor();
               Console.WriteLine("\n");
            } 
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Matrix size (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minimum value (a): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maximum value (b): ");
            int b = Convert.ToInt32(Console.ReadLine());
            PrintMatrix(Matrix(n, a, b));

            int[,] matrix = Matrix(n, a, b);
        }
    }
}
