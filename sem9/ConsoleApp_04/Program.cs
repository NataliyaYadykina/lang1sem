// 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453-> 12
// 45-> 9

int PrintSumSymbolsNumber(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n % 10 + PrintSumSymbolsNumber(n / 10);
}

Console.Write("Write N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintSumSymbolsNumber(n));