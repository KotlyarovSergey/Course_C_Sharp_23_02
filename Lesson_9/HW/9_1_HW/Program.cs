// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void EvenNummsFromTo(int m, int n)
{
    if (m == n + 1) return;
    EvenNummsFromTo(m, n - 1);
    if (n % 2 == 0) System.Console.Write($"{n} ");
}

void EvenNummsFromToVer2(int m, int n)
{
    if (m >= n + 1) return;
    EvenNummsFromTo(m, n - 2);
    System.Console.Write($"{n} ");
}




int m = GetUserDataInteger("От: ");
int n = GetUserDataInteger("До: ");

EvenNummsFromTo(m, n);
Console.WriteLine();

if (n % 2 == 1) n--;
EvenNummsFromToVer2(m, n);