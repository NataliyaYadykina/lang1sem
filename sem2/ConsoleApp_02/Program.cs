//Напишите программу, которая выводит случайное трёхзначное число и
//удаляет вторую цифру этого числа.
//

// Случайное число
int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int a1 = number / 100;
Console.WriteLine(a1);
int a2 = number % 10;
Console.WriteLine(a2);
int result = a1 * 10 + a2;
Console.WriteLine(result);