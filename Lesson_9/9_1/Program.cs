// Задайте занчение N. Напишите программу, которая
// выведет все натуральные числав промежутке
// от 1 до N при помощи рекурсии.


int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string NaturalLine(int n)
{
    if (n < 1) return "";
    
    //string res = NaturalLine(n - 1);
    //return res  + n + ", ";
    return NaturalLine(n - 1) + n + ", "; 
}

string NaturalLineReverse(int n, int max)
{
    if (n > max) return "";
    
    //string res = NaturalLine(n - 1);
    //return res  + n + ", ";
    return NaturalLineReverse(n + 1, max) + n + ", "; 
}


void SeriesNums(int n)
{
    if (n == 0) return;
    SeriesNums(n - 1);
    Console.Write($"{n}, ");
}

int n = GetUserDataInteger("Количество чисел: ");
Console.WriteLine(NaturalLine(n));
Console.WriteLine(NaturalLineReverse(1, n));
SeriesNums(n);