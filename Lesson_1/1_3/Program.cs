// 3. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int i;
for (i = 0 - num; i <= num; i++)
{
    Console.Write(i.ToString() + " ");
}
Console.WriteLine();

i = -num;
while(i <= num)
{
    Console.Write(i.ToString() + " ");
    i++;
}