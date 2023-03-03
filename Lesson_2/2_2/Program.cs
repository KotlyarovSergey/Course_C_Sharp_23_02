(int, int) MaxDigit()
{
    int num = new Random().Next(10, 100);
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit)
    {
        secondDigit = firstDigit;
    }
    return (num, secondDigit);
}


(int number, int max) = MaxDigit();

Console.WriteLine($"{number} -> {max}");
