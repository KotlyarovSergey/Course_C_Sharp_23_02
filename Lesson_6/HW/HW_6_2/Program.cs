// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("k1: ");
double k1 = Double.Parse(Console.ReadLine()!);
Console.Write("b1: ");
double b1 = Double.Parse(Console.ReadLine()!);
Console.Write("k2: ");
double k2 = Double.Parse(Console.ReadLine()!);
Console.Write("b2: ");
double b2 = Double.Parse(Console.ReadLine()!);

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = x * k1 + b1;
    //Console.WriteLine("Прямые пересекаются в точке ({0}, {1})", Math.Round(x, 2), Math.Round(y, 2));
    Console.WriteLine("Прямые пересекаются в точке ({0:F2}, {1:F2})", x, y);
}