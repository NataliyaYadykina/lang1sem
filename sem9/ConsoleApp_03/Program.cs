// 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 6, 7, 8"

int PrintNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }

    int tempResult = m;
    Console.WriteLine(tempResult);
    return PrintNumbers(m + 1, n);
}

Console.Write("Write M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(m, n));