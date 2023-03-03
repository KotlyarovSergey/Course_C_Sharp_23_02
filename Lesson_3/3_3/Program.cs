// Напишите программу которая принимает на вход число N
// и выдает таблицу квадратов чисел от 1 до N

void Div (int n)
{
    int i =1;
    while(i <= n)
    {
        Console.Write($"{Math.Pow(i, 2)} ");
        i++;
    }
}

Console.Write("Вводим: ");
int num = int.Parse(Console.ReadLine()!);
Div(num);