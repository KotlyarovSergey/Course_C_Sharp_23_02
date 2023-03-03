// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + + Math.Pow(z2 - z1, 2)), 2);
}

Console.WriteLine(Distance(3, 6, 8, 2, 1, -7));
Console.WriteLine(Distance(7, -5, 0, 1, -1, 9));