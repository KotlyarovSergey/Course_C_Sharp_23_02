// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int NumberPower(int num, int degree)
{
    if( degree == 0 )  return 1;
    return NumberPower(num, degree-1) * num;
}


int num = GetUserDataInteger("Число: ");
int degree = GetUserDataInteger("Степень: ");

Console.WriteLine(NumberPower(num, degree));