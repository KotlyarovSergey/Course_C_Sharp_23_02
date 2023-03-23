// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.


int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SummNummsFromTo(int m, int n)
{
    if (m == n + 1) return 0;
    return n + SummNummsFromTo(m, n - 1);
}

int SummNummsFromToVer2(int nFrom, int nTo)
{
    if(nFrom > nTo) return 0;
    return nFrom + SummNummsFromToVer2(nFrom + 1, nTo);
}




int m = GetUserDataInteger("От: ");
int n = GetUserDataInteger("До: ");

Console.WriteLine(SummNummsFromTo(m, n));
Console.WriteLine(SummNummsFromToVer2(m, n));
