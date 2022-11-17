// задайте двумерный массив размером m*n, 
// заполненный случайными числами

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

Console.Write("Write m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array, m, n);
