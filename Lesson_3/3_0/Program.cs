// Нап прогр к-я принимает на вход координаты точки (X, Y)
// причем X != 0 и Y != 0, и выдает номер четврти в которой находится эта точка

void Quarters(int x, int y)
{
    if (x == 0 || y == 0) 
        Console.WriteLine("x = 0, y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}

Quarters(2, -3);