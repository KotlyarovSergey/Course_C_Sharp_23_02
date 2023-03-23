// // 1. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

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

void ChangeRows(int[,] array, int row1, int row2)
{
    for (int i = 0; i < array.GetLength(1); i++)
        (array[row1, i], array[row2, i]) = (array[row2, i], array[row1, i]);
}

int rows = GetUserDataInteger("Количество строк: ");
int columns = GetUserDataInteger("Количество столбцов: ");
int start = GetUserDataInteger("Минимальный элемент: ");
int stop = GetUserDataInteger("Максимальный элемент: ");

int[,] array = RandomArray(rows, columns, start, stop);
Print(array);
Console.WriteLine();

ChangeRows(array, 0, array.GetLength(0) - 1);
Print(array);
