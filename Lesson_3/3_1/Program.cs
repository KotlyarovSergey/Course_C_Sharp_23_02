// Напишите программу, которая по заданному номеру четверти
// показывает диапазон возожможных координат точек в этой четврти (x, y)

void Quarters(int num)
{
    if (num == 1)
        Console.WriteLine("X > 0, Y > 0");
    else if (num == 2)
        Console.WriteLine("X < 0, Y > 0");
    else if (num == 3)
        Console.WriteLine("X < 0, Y < 0");
    else if (num == 4)
        Console.WriteLine("X > 0, Y < 0");
    else
        Console.WriteLine("error");
}

Quarters(int.Parse(Console.ReadLine()!));