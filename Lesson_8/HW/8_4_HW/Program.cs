// Задайте двумерный массив из целых чисел. Напишите программу, которая 
// удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GetUserMatrix()
{
    int rows = GetUserDataInteger("Количество строк: ");
    int columns = GetUserDataInteger("Количество столбцов: ");
    int start = GetUserDataInteger("Минимальный элемент: ");
    int stop = GetUserDataInteger("Максимальный элемент: ");

    //int[,] matrix = new int[3,4]{{9,9,9,9},{8,8,1,8},{7,7,7,7}};
    int[,] matrix = RandomArray(rows, columns, start, stop);
    return matrix;
}

int[,] RandomArray(int rows, int columns, int minItem, int maxItem)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minItem, maxItem + 1);
    return array;
}

void Print2dArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{array[i, j],-4} ");
        Console.WriteLine();
    }
}

(int row, int column) FindMinimal(int[,] array)
{
    int minItem = array[0, 0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minItem)
            {
                minItem = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}

int[,] DeleteIntersection(int[,] array, int row, int column)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int r, c;

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        r = i;
        if (i >= row) r++;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            c = j;
            if (j >= column) c++;
            newArray[i, j] = array[r, c];
        }
    }
    return newArray;
}

int[,] myArray = GetUserMatrix();
Print2dArray(myArray);

int row;
int column;
(row, column) = FindMinimal(myArray);

if (myArray.GetLength(0) == 1 || myArray.GetLength(1) == 1)
{
    Console.WriteLine("Всё удалили, ничего не осталось.");
    return;
}

int[,] newArray = DeleteIntersection(myArray, row, column);
Console.WriteLine("Новый массив:");
Print2dArray(newArray);

