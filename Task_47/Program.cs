// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write ("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = rnd.NextDouble();
        Console.Write (matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
