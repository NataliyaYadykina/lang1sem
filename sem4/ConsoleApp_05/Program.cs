// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// Console.WriteLine("[{0}]", string.Join(", ", array));


void PrintArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void GetArray(int[] array)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}

int[] arr = new int[8];

PrintArr(arr);
GetArray(arr);
PrintArr(arr);
