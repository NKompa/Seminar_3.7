// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int rows = int.Parse(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];

int count = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,11);
        if(i==j) 
        {
            count = count + matrix[i,j];
        }

        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов диагонали = {count}");