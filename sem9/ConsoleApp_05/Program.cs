// 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

int PovAtoB(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    return a * PovAtoB(a, b - 1);
}

Console.Write("Write A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Write B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PovAtoB(a, b));



//int Akkerman(int m, int n)
//{
//    if (m == 0)
//    {
//        return n + 1;
//    }
//    else if (n == 0 && m > 0)
//    {
//        return Akkerman(m - 1, 1);
//    }
//    else
//    {
//        return (Akkerman(m - 1, Akkerman(m, n - 1)));
//    }
//}
