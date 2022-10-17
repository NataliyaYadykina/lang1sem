// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
//

Console.Write("Vvedi chislo: ");
int a = Convert.ToInt32(Console.ReadLine());


if(a % 7 == 0 && a % 23 == 0) Console.WriteLine("Kratno");
else
{
    Console.WriteLine("Ne kratno!");
}
