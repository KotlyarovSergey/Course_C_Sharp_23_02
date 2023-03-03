int LastDigit(int number)
{
    return number % 10;
}


int a = new Random().Next(100, 1000);

//Console.WriteLine($"{a} {a%10}" );
Console.WriteLine($"{a} -> {LastDigit(a)}" );