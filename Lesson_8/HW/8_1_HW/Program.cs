// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortAnyRow(int[,] array, int row)
{
    int length = array.GetLength(1);
    for (int i = 0; i < length - 1; i++)
    {
        for (int j = 0; j < length - i -1; j++)
        {
            if (array[row, j] < array[row, j + 1])
                (array[row, j], array[row, j + 1]) = (array[row, j + 1], array[row, j]);
        }
    }
}

void SortingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortAnyRow(array, i);
    }
}

int rows = GetUserDataInteger("Количество строк: ");
int columns = GetUserDataInteger("Количество столбцов: ");
int start = GetUserDataInteger("Минимальный элемент: ");
int stop = GetUserDataInteger("Максимальный элемент: ");

int[,] myArray = RandomArray(rows, columns, start, stop);
Print(myArray);
Console.WriteLine();

SortingArray(myArray);
Print(myArray);