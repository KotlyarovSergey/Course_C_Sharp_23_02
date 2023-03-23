// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
            Console.Write($"{array[i, j], -3} ");
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

int[,] TranspositionMatrix(int[,] array)
{
    int originalRows = array.GetLength(0);
    int originalColmns = array.GetLength(1);
    int[,] newMatrix = new int[originalColmns, originalRows];
    for (int i = 0; i < originalRows; i++)
    {
        for (int j = 0; j < originalColmns; j++)
        {
            newMatrix[j, i] = array[i, j];
        }
    }
    return newMatrix;
}


void TransQuadMatrix(int[,] array)
{
    for (int i = 1; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
}

void TransQuadMatrix2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
}



int rows = GetUserDataInteger("Количество строк: ");
int columns = GetUserDataInteger("Количество столбцов: ");
int start = GetUserDataInteger("Минимальный элемент: ");
int stop = GetUserDataInteger("Максимальный элемент: ");

int[,] array = RandomArray(rows, columns, start, stop);
Print(array);
Console.WriteLine();

//int[,] transArray = TranspositionMatrix(array);
//Print(transArray);
//Console.WriteLine();

if (array.GetLength(0) == array.GetLength(1))
{
    TransQuadMatrix2(array);
    Print(array);
}