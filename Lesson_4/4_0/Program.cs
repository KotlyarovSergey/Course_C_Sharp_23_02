// напишите программу, которая принимает
// на выход число (А) и выдает сумму чисел от 1 до А

int SumNum(int num)
{
    int allSum = 0;
    for(int i = 1; i <= num; i++)
    {
        allSum += i;
    }
    return allSum;
}

int A = int.Parse(Console.ReadLine()!);
int res = SumNum(A);
Console.WriteLine(res);
