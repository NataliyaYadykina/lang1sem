// 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// Заполнить массив
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Вывести двумерный массив в консоль в виде матрицы.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}", array[i, j]);
        }
        Console.WriteLine();
    }
}

// 

Console.Write("Write m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());

/*int[,] arr = new int[m, n];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();*/

int[] array = new int[10] { 1,1,4,5,2,8,5,4,2,4};
Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < array.Length; i++)
{
    if (!dict.ContainsKey(array[i]))
    {
        dict.Add(array[i], 1);
    }
    else
    {
        dict[array[i]]++;
    }
}

var keysColl = dict.Keys;

foreach(var dic in dict)
{
    Console.WriteLine($"{dic.Key} встречается {dic.Value} раз");
}

