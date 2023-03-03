// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

void CheckDivide(int numA, int numB)
{
    int reminder = numA % numB;

    if (reminder == 0)
    {
        Console.WriteLine($"{numA} нацело делится на {numB}");
    }
    else
    {
        Console.WriteLine($"Остаток от деления {numA} на {numB} равен {reminder}");
    }
}


Console.Write("Чиcло 1: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Чиcло 2: ");
int b = int.Parse(Console.ReadLine()!);

CheckDivide(a,b);