// 63: Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 5 до 1.
// N = 5-> "5, 4, 3, 2, 1"
// N = 6-> "6, 5, 4, 3, 2, 1"

int PrintNumbers(int n)
{
    if (n == 1)
    {
        return 1;
    }

    int tempResult = n;
    Console.WriteLine(tempResult);
    return PrintNumbers(n - 1);
}

Console.Write("Write N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(n));