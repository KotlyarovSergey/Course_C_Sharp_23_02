// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num = int.Parse(Console.ReadLine()!);
if (num == 1)
{
    Console.WriteLine("Понедельник");
}
else if (num == 2)
{
    Console.WriteLine("Вторики");
}
else if (num == 3)
{
    Console.WriteLine("сруда");
}
else if (num == 4)
{
    Console.WriteLine("четверг");
}
else if (num == 5)
{
    Console.WriteLine("Пятница");
}
else if (num == 6)
{
    Console.WriteLine("суббота");
}
else if (num == 7)
{
    Console.WriteLine("воскреснье");
}
else
{
    Console.WriteLine("ошибка ввода");
}

