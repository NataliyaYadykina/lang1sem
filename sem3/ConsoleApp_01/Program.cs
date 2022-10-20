// See https://aka.ms/new-console-template for more information

// Получить номер четверти на плоскости
void /*int*/ GetPointArea(int coordX, int coordY)
{
    /*int numberArea = 0;
    if(coordX > 0 && coordY > 0) numberArea = 1;
    if(coordX < 0 && coordY > 0) numberArea = 2;
    if(coordX < 0 && coordY < 0) numberArea = 3;
    if(coordX > 0 && coordY < 0) numberArea = 4;
    return numberArea;*/
    
    /*if(coordX > 0 && coordY > 0) return 1;
    if(coordX < 0 && coordY > 0) return 2;
    if(coordX < 0 && coordY < 0) return 3;
    if(coordX > 0 && coordY < 0) return 4;
    return 0;*/

    if(coordX > 0 && coordY > 0)
    {
        Console.WriteLine("1");
        return;
    }
    if(coordX < 0 && coordY > 0)
    {
        Console.WriteLine("2");
        return;
    }
    if(coordX < 0 && coordY < 0)
    {
        Console.WriteLine("3");
        return;
    }
    if(coordX > 0 && coordY < 0)
    {
        Console.WriteLine("4");
        return;
    }
    Console.WriteLine("0");
}

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

/*int numberArea = */ GetPointArea(x, y);
//Console.WriteLine(numberArea);
