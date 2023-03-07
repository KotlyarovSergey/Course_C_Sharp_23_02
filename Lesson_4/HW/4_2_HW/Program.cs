// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе

int DigitSumm(int number)
{
    int sum = 0;
    for(int i = 0; number > 0; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}


Console.Write("Введите число ");
Console.WriteLine(DigitSumm(int.Parse(Console.ReadLine()!))); 
