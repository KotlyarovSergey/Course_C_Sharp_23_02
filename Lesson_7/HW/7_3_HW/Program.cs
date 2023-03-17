// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] RandomArray(int rows, int columns, int minItem, int maxItem)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minItem, maxItem + 1);
    return array;
}

double AverageInColumn(int[,] array, int column)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        sum += array[i, column];

    return (double)sum / array.GetLongLength(0);
}


/*
Console.Write("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Минимальный элемент: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Максимальный элемент: ");
int stop = int.Parse(Console.ReadLine()!);
int[,] array = RandomArray(rows, columns, start, stop);
*/
int[,] array = RandomArray(7, 7, 10, 99);
Print(array);
System.Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
    Console.WriteLine($"Среднее по столбцу {i + 1}: {AverageInColumn(array, i):F2}");
}