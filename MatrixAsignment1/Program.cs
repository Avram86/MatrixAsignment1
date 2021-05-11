using System;
using System.Text;

namespace MatrixAsignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the size of the matrix :");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n))
            {
                //instantiem matricea
                var matrix = MatrixInstantiation(n);
                ShowSecondaryDiagonal(n, matrix);
                TranspusaMatricii(n, matrix);
                IsIdentityMatrix(n, matrix);
            }


        }

        private static int[,] MatrixInstantiation(int n)
        {
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Please enter a number:");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int element))
                    {
                        matrix[i, j] = element;
                    }
                    else
                    {
                        Console.Write("You need to write a number!");
                        j--;
                        continue;
                    }

                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                    if (j == n - 1)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
            }

            return matrix;
        }

        public static void ShowSecondaryDiagonal(int n, int[,] matrix)
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (i + j == n - 1)
                    {
                        str.Append($"{matrix[i, j]}, ");
                    }
                }
            }
            Console.WriteLine($" The secondary diagonal is: {str.ToString()}");

        }

        public static void TranspusaMatricii(int n, int[,] matrix)
        {
            int[,] transpusa = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        transpusa[i, j] = matrix[i, j];
                    }
                    else
                    {
                        transpusa[i, j] = matrix[j, i];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{transpusa[i,j]} ");
                    if (j == n - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        public static void IsIdentityMatrix(int n, int[,] matrix)
        {
            bool isIdentity = false;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if ((i == j && matrix[i, j] == 1)|| (i != j && matrix[i, j] == 0))
                    {
                        isIdentity = true;
                    }
                    else
                    {
                        isIdentity = false;
                    }
                }
            }

            Console.WriteLine($"It is an Identity matrix: {isIdentity}"); 
        }
    }
}
