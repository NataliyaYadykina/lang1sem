Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sqrNum2 = num2 * num2;

if(num1 == sqrNum2)
{
    Console.WriteLine("Первое число является квадратом второго!");
}
else
{
    Console.WriteLine("Первое число Не является квадратом второго!");
}