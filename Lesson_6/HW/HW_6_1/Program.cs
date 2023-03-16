// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

string RightEnding(int num)
{
    string result = string.Empty;
    int remainder = num % 10;
    if (num % 100 > 10 && num % 100 < 20) result = "положительных чисел";       // для надцатых чисел 11-19
    else if (remainder == 1) result = "положительное число";                // для заканчивающихся на 1
    else if (remainder >= 2 && remainder <= 4) result = "положительных числа";      // от 2 до 4
    else result = "положительных чисел";        // остальные
    return result;
}

int count = 0;
int input = 1;
while (input != 0)
{
    Console.Write("Введите число (\"0\" для выхода): ");
    input = int.Parse(Console.ReadLine()!);
    //if (input == 0) break;
    //else if (input > 0 ) count++;
    if (input > 0) count++;
}
Console.WriteLine();

//Console.WriteLine("Вы ввели {0} положительнвх чисел", count);
Console.WriteLine("Вы ввели {0} {1}.", count, RightEnding(count));

/*
for (int i = 99; i < 125; i++)
{
    Console.WriteLine(i + " " + RightEnding(i));
}
*/