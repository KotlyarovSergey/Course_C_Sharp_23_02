// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int Power(int number, int pow)
{
    int res = 1;
    for(int i = 1; i <= pow; i++)
    {
        res *= number;
    }
    return res;
}

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine(Power(A, B));