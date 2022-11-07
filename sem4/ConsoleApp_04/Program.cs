// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.

int GetFactorial(int number)
{
    int res = 1;
    for (int i = 1; i <= number; i++)
    {
        res = res * i;
    }
    return res;
}

//int num = -12345;
//string strNum = Math.Abs(num).ToString();
//Console.WriteLine(strNum.Length);


Console.Write("Write number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetFactorial(a));

