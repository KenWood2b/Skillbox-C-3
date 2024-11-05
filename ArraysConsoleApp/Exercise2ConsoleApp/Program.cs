using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Размер матриц
            int rows = 2;
            int columns = 3;

            // Объявление и инициализация матриц A и B
            int[,] matrixA = { { 2, -3, 1 }, { 5, 4, -2 } };
            int[,] matrixB = { { 4, 2, -5 }, { -4, 1, 3 } };
            int[,] matrixSum = new int[rows, columns];

            // Вывод матрицы A
            Console.WriteLine("Матрица A:");
            PrintMatrix(matrixA, rows, columns);

            // Вывод матрицы B
            Console.WriteLine("\nМатрица B:");
            PrintMatrix(matrixB, rows, columns);

            // Сложение матриц A и B и вывод результата
            Console.WriteLine("\nСумма матриц A и B:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixSum[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            PrintMatrix(matrixSum, rows, columns);
        }

        // Метод для вывода матрицы на экран
        static void PrintMatrix(int[,] matrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
