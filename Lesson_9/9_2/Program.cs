// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.


int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void NummsFromTo(int m, int n)
{
 if (m == n + 1) return;
    NummsFromTo(m, n - 1);
    System.Console.Write($"{n}, ");


}




int m = GetUserDataInteger("От: ");
int n = GetUserDataInteger("До: ");

NummsFromTo(m, n);
