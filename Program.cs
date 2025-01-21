using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;

            Console.Write("Enter the number of rows for the matrices: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns for the matrices: ");
            cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] sum = new int[rows, cols];
            int[,] difference = new int[rows, cols];
            int[,] product = new int[rows, cols];

            Console.WriteLine("Enter elements for the first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element at position ({i + 1}, {j + 1}): ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements for the second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element at position ({i + 1}, {j + 1}): ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    difference[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            if (cols == rows)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        product[i, j] = 0;
                        for (int k = 0; k < cols; k++)
                        {
                            product[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Matrix multiplication is not possible for the given dimensions.");
            }

            Console.WriteLine("\nMatrix 1:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix 2:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSum of the matrices:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDifference of the matrices:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(difference[i, j] + "\t");
                }
                Console.WriteLine();
            }

            if (cols == rows)
            {
                Console.WriteLine("\nProduct of the matrices:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(product[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
