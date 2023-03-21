// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Print2dArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{array[i, j],-3} ");
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

int SumInRow(int[,] array, int row)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[row, i];
    }
    return sum;
}

int GetRowWithMinSum(int[,] array)
{
    int minSum = SumInRow(array, 0);
    int rowIndex = 0;
    for (int rw = 1; rw < array.GetLength(0); rw++)
    {
        int sum = SumInRow(array, rw);

        if (sum < minSum)
        {
            rowIndex = rw;
            minSum = sum;
        }
        //Console.WriteLine($"row: {rw}, sum: {sum}");
    }

    return rowIndex;
}


int rows = GetUserDataInteger("Количество строк: ");
int columns = GetUserDataInteger("Количество столбцов: ");
int start = GetUserDataInteger("Минимальный элемент: ");
int stop = GetUserDataInteger("Максимальный элемент: ");

int[,] myArray = RandomArray(rows, columns, start, stop);
Print2dArray(myArray);
Console.WriteLine();

//int[] sums = SumsOfRows(myArray);

int rowIndex = GetRowWithMinSum(myArray);
Console.WriteLine("Не знаю, что имел в виду заказчик. Поэтому ответа 3:");
Console.WriteLine($"Индекс строки с наименьшей суммой: {rowIndex}");
Console.WriteLine($"Номер строки с наименьшей суммой: {rowIndex + 1}");
Console.Write("Строка с наименьшей суммой: ");
for (int i = 0; i < myArray.GetLength(1); i++)
    Console.Write($"{myArray[rowIndex, i]}  ");
