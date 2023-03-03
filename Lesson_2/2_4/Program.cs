// See https://aka.ms/new-console-template for more information
void checkNumbers(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Делится");
    }
    else
    {
        Console.WriteLine("Не делится");
    }
}


Console.Write("Чиcло : ");
int a = int.Parse(Console.ReadLine()!);

checkNumbers(a);






//Console.WriteLine("Hello, World!");
