using System;

namespace TaskFourPartOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];
            Random random = new Random();
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(-100, 100);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов составляет {sum}");
        }
    }
}
