// Вариант решения Task01 из семинара 3.6
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь: 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3.

Console.Write("Сколько чисел вы хотите ввести? ");
int numb = Convert.ToInt32(Console.ReadLine());

int[] array = new int [numb];

int PositiveCount(int count)
{
    int countOfPositive = 0;
    for(int i = 0; i < count;i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            countOfPositive+=1;
        }
        Console.WriteLine("[{0}]",string.Join(",", array));
    }
    return countOfPositive;
}
int posCount = PositiveCount(numb);
Console.Write($"количество положительных чисел = {posCount}");

