// Напишите программу, которая на вход принимает целое число и выдает его квадрат

//запрос числа от пользователя
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Квадрат исходного числа
int sqrNumber = number * number;

// Вывод результата на экран
Console.WriteLine($"Квадрат Вашего числа = {sqrNumber}");
