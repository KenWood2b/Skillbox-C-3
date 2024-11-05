using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        // Запрашиваем у пользователя количество строк и столбцов для матрицы
        Console.WriteLine("Введите количество строк:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        int columns = int.Parse(Console.ReadLine());

        // Создаем матрицу и переменную для хранения суммы элементов
        int[,] matrix = new int[rows, columns];
        int sum = 0;

        Console.WriteLine("Случайная матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(-10, 11);  // заполняем случайными числами от -10 до 10
                sum += matrix[i, j];
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Вывод суммы всех элементов матрицы
        Console.WriteLine($"\nСумма всех элементов матрицы: {sum}");
        Console.ReadKey();
    }
}
