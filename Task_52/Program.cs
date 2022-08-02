/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. */

Console.Write ("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rnd.Next(-10, 10);
        Console.Write(matrix[i,j] + ", ");
    }
    Console.WriteLine();
}

for (int j = 0; j < n; j++)
{
    int mean = 0;
    for (int i = 0; i < m; i++)
    {
        mean += matrix[i,j];
    }
    Console.WriteLine("mean is:  {0}", mean / m);
}