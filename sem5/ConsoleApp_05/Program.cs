// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void PrintArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] NewArray(int[] array)
{
    int length = array.Length;
    int newLength = length / 2;
    if(length%2 != 0) 
    {
        newLength = length / 2 + 1;
    }

    int[] new_array = new int[newLength];

    for (int i = 0; i < length/2; i++)
    {
        new_array[i] = array[i] * array[length - i - 1];
    }
    if(length%2 != 0)
    {
        new_array[newLength - 1] = array[length/2];
    }
    return new_array;
}

int[] array = new int[5];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}

PrintArr(array);

int[] new_array = NewArray(array);

PrintArr(new_array);
