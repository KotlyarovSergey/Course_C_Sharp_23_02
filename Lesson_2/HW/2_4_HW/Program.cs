// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Weeks(int number)
{
    if (number > 7 )
        number %= 7;
    if (number < 6)
        Console.WriteLine("На рабту!");        
    else
        Console.WriteLine("Ура!! Выходной!!!!!");
}

Console.Write("Чиcло : ");
Weeks(int.Parse(Console.ReadLine()!));