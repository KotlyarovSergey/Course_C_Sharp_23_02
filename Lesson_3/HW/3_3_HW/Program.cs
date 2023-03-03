// Напишите программу которая принимает на вход число N
// и выдает таблицу кубов чисел от 1 до N

void Powers (int n)
{
    int i = 1;
    while(i <= n)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
        i++;
    }
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Powers(num);