// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void NewArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length/2; i++)
    {
        Console.Write(array[i] * array[length - i - 1] + " ");
    }
    if(length%2 != 0)
    {
        Console.Write(array[length/2]);
    }
}

int[] array = new int[6];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

NewArray(array);
