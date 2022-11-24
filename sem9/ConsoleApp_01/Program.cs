// Пример рекурсии - нахождение факториала.

int FactorialFor(int n)
{
    int res = 1;
    for(int i = 1; i <= n; i++)
    {
        res *= i;
    }
    return res;
}

int FactorialR(int n)
{
    if (n == 1)
    {
        return 1;
    }

    return n * FactorialR(n - 1);
}

Console.Write("Write N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FactorialR(n));
