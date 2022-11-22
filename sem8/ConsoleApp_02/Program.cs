// 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.


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

// Поменять в новом массиве местами строки и столбцы
int[,] ChangeArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
    }
    return result;
}

Console.Write("Write m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m == n)
{
    int[,] arr = new int[m, n];
    FillArray(arr);
    Console.WriteLine();

    int[,] resultArray = ChangeArray(arr);

    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            Console.Write(resultArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Массив должен быть квадратным!");
}

