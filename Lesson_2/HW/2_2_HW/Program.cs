// Задача 2: Напишите программу, которая выводит случайное трёначное 
// число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int DeleteSecondDigit(int number)
{
    if (number < 100 || number > 999)
        return -1;
    else
        return (number / 100) * 10 + number % 10;

}

int num = new Random().Next(10,1500);

Console.WriteLine($"{num} -> {DeleteSecondDigit(num)}");
