Console.Write("Vvedi A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedi B: ");
int b = Convert.ToInt32(Console.ReadLine());


if(a != b * b && b != a * a) Console.WriteLine("Никакое число не является квадратом другого.");
else
{
    if(a == b * b) Console.WriteLine($"{a} является квадратом числа {b}.");
    else Console.WriteLine($"{b} является квадратом числа {a}.");
}
