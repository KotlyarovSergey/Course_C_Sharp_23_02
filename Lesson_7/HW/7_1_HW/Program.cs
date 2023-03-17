// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void Print(double[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write("{0:F2} ", array[i, j]);
        Console.WriteLine();
    }
}

double[,] RandomArray(int rows, int columns, double minItem, double maxItem)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            //arr[i, j] = new Random().Next(from, to);
            array[i, j] = new Random().NextDouble() * (maxItem - minItem) + minItem;
    return array;
}

Console.Write("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Минимальный элемент: ");
double start = double.Parse(Console.ReadLine()!);
Console.Write("Максимальный элемент: ");
double stop = double.Parse(Console.ReadLine()!);

double[,] array = RandomArray(rows, columns, start, stop);
Print(array);