Console.Write("Vvedi A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedi B: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a % b == 0)
{
    Console.WriteLine("Kratno");
}
else
{
    int ost = a % b;
    Console.WriteLine($"Ostatok raven {ost}.");
}