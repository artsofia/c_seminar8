using System;

namespace MyLib
{
    public static class MyLibClass
    {
        public static int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void FillArray(double[,] matrix, int minVelue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.NextDouble() * (maxValue - minVelue) + minVelue;
                    matrix[i, j] = Math.Round(matrix[i, j], 1);
                }
            }
        }

        public static void PrintArray(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void FillArray(int[,] matrix, int minVelue = -9, int maxValue = 9)
         {
            maxValue++;
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(minVelue, maxValue);
                }
            }
        }

        public static void PrintArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}