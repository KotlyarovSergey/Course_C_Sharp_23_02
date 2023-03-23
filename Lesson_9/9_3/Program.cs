// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.


int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Summary(int n)
{
    if (n < 1) return 0;
    return n % 10 + Summary(n / 10);
}

int n = GetUserDataInteger("Число: ");
Console.WriteLine(Summary(n));