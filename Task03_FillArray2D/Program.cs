// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.m = 3, n = 4.

int rows = int.Parse(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}