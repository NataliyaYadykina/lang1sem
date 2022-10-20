//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу квадратов чисел от 1 до N.

// Получаем таблицу квадратов
void PrintSquaresToConsole(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i * i);
    }
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintSquaresToConsole(n);
