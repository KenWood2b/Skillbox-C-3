using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

       
        Console.WriteLine("Введите количество строк:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        int columns = int.Parse(Console.ReadLine());

        
        int[,] matrix = new int[rows, columns];
        int sum = 0;

        Console.WriteLine("Случайная матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(-10, 11); 
                sum += matrix[i, j];
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

       
        Console.WriteLine($"\nСумма всех элементов матрицы: {sum}");
        Console.ReadKey();
    }
}
