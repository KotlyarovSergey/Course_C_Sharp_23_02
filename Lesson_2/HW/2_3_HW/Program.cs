// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ThirdDigit(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        //int a = number / 100 % 10;
        Console.WriteLine($"{number / 100 % 10}");
    }
}

Console.Write("Чиcло : ");
ThirdDigit(int.Parse(Console.ReadLine()!));