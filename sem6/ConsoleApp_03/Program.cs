// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ConvertNum(int number)
{
    string res = string.Empty;
    while (number > 0)
    {
        res = Convert.ToString(number % 2) + res;
        number /= 2;
    }
    return res;
}

int number = new Random().Next(1,100);
Console.WriteLine(number);
Console.WriteLine(ConvertNum(number));