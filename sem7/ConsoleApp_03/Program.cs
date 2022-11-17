// 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// Заполнить массив.
void FillArray(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-100, 101);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Изменить элементы массива с четными индексами
void ChangeArray(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
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

FillArray(arr, m, n);
Console.WriteLine();
ChangeArray(arr, m, n);
