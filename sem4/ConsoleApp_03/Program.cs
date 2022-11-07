// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

int NumLength(int number)
{
    string strNum = Math.Abs(number).ToString();
    int length = strNum.Length;
    return length;
}

//int num = -12345;
//string strNum = Math.Abs(num).ToString();
//Console.WriteLine(strNum.Length);


Console.Write("Write number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumLength(a));
