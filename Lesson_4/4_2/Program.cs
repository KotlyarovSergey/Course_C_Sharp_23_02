// Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.

int MultNum(int num)
{
    int allMult = 1;
    for(int i = 1; i <= num; i++)
    {
        allMult *= i;
    }
    return allMult;
}

int A = int.Parse(Console.ReadLine()!);
int res = MultNum(A);
Console.WriteLine(res);
