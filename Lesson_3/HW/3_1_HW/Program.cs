// Напишите программу которая принимает на вход пятизначное число
// и проверяет, явлется ли оно палиндромом

void Palindrom(int num)
{
    if (num > 99999 || num < 10000)
        Console.WriteLine("Error");
    else if (num % 10 == num / 10000 && num / 10 % 10 == num / 1000 % 10)
        Console.WriteLine("Ура! Это палиндром");
    else
        Console.WriteLine("Увы, это просто число");
}

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
Palindrom(num);