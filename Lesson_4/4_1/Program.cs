// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int numCont (int number)
{
    int quantity = 0;
    for(int i = 1; number > 0; i++)
    {
        number /= 10;
        quantity++;
    }
    return quantity;
}

int A = int.Parse(Console.ReadLine()!);
int quantity = numCont(A);
Console.WriteLine(quantity);