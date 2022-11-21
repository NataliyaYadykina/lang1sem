// 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// Заполнить массив.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Поменять местами первую и последнюю строку массива
void ChangeStringArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == 0)
            {
                int temp = array[i, j];
                array[i, j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) - 1, j] = temp;
            }
            
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Write m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
FillArray(arr);
Console.WriteLine();
ChangeStringArray(arr);