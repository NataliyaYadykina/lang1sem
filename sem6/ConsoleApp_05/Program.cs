// 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] RandomFillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 250);
        //Console.Write(array[i] + " ");
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i] + 1;
    }
    return copyArray;
}

Console.Write("Set length of array: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[number];

RandomFillArray(arr);
Console.Write("First array: ");
PrintArr(arr);
int[] copyArr = CopyArray(arr);
Console.Write("Copy array: ");
PrintArr(copyArr);
