/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента, или же указание, что такого элемента нет. */

Console.Write ("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write ("Enter i0: ");
int i0 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter j0: ");
int j0 = Convert.ToInt32(Console.ReadLine());

if (i0 >= m || j0 >= n) 
{
    Console.WriteLine ("No element");
}

int[,] matrix = new int[m,n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rnd.Next(-10, 10);
        if (i == i0 && j == j0) 
        {
            Console.WriteLine(matrix[i, j]);
        }
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}


