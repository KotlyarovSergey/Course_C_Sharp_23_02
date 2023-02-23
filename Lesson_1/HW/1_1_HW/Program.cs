// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA  = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numberB  = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    //Console.WriteLine("max = " + $"{numberA}");
    Console.WriteLine($"max = {numberA}");
}
else if (numberB > numberA)
{
    Console.WriteLine($"max = {numberB}");
}
else    // сюда попадаем только если числа равны
{
    Console.WriteLine("Числа равны");
}

        