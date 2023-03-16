// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.

void Fib(int a)
{
    int festNum = 0;
    int secontNum = 1;
    for (int i = 0; i < a; i++)
    {
        Console.Write(festNum + " ");
        (festNum, secontNum) = (secontNum, festNum + secontNum);
    }
}
int A = int.Parse(Console.ReadLine()!);
Fib(A);