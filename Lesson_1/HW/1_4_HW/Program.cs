// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number  = int.Parse(Console.ReadLine()!);
int index = 2;

while(index <= number)      // если введено отрицательное число, то в этот цикл не поадаем
{
    Console.Write($"{index} ");
    index += 2;
}

if (number < 0)             // а сюда пападаем если ведено отрицатльное число
{
    index = -2;
    while(index >= number)
    {
        Console.Write($"{index} ");
        index -= 2;
    }
}
// при -1, 0, 1 вообще ничего не выводим (точнее пустую строку)
Console.WriteLine();
