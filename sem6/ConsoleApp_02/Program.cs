/* 40: Напишите программу, которая принимает на вход три числа и проверяет, 
 * может ли существовать треугольник с сторонами такой длины.
 Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

bool isTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.Write("Write a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Write b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Write c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(isTriangle(a, b, c));