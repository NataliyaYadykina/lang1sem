// See https://aka.ms/new-console-template for more information
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n <= 0)
{
    Console.Write("Введите положительное число N: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int negativeN = n * -1;
while(negativeN <= n)
{
    Console.WriteLine(negativeN);
    negativeN = negativeN +1;
}
