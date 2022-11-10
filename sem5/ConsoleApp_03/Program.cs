// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

bool SearchArray(int[] array, int number)
{
    bool res = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            res = true;
            break;
        }
    }
    return res;
}

int[] array = new int[10] {2, 1, 0, -5, -1, 4, 0, 3, -5, 4};

Console.Write("Write number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool res = SearchArray(array, number);
Console.WriteLine(res);
