// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

// Найти расстояние между точками в 2D пространстве
double GetDistance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return distance;
}

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = GetDistance(x1, y1, x2, y2);
Console.WriteLine(distance);