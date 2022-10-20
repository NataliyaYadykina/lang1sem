// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Получить номер координатной четверти
string GetDiapason(int pointArea)
{
    string diapason = "Неверный номер четверти. Попробуйте снова.";
    if(pointArea == 1) diapason = "x > 0, y > 0";
    if(pointArea == 2) diapason = "x < 0, y > 0";
    if(pointArea == 3) diapason = "x < 0, y < 0";
    if(pointArea == 4) diapason = "x > 0, y < 0";
    return diapason;
}

Console.Write("Введите номер координатной четверти: ");
int pointArea = Convert.ToInt32(Console.ReadLine());

string diapason = GetDiapason(pointArea);
Console.WriteLine(diapason);
