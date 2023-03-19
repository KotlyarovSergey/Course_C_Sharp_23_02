// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

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

string SearchItem(int[,] array, int row, int column)
{
    string pref = $"[{row}, {column}] -> ";
    //if (row > array.GetLength(0) || column > array.GetLength(1))
    if (row > array.GetLength(0) || column > array.GetLength(1) || row < 1 || column < 1)
        return pref + "Не существует";
    else
        return pref + array[row - 1, column - 1];
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
int[,] array = RandomArray(4, 7, 10, 99);
Print(array);

Console.Write("Номер строки искомого элемента: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Номер стрлбца искомого элемента: ");
int column = int.Parse(Console.ReadLine()!);
Console.WriteLine(SearchItem(array, row, column));