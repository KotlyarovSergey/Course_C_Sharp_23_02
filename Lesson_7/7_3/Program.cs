// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int MainDiagonalSumm(int[,] array)
{
    int sum = 0;
    int minIdex = array.GetLength(0);
    if (array.GetLength(1) < minIdex) minIdex = array.GetLength(1);

    for (int i = 0; i < minIdex; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int row_num = int.Parse(Console.ReadLine()!);
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
Console.WriteLine();
Console.WriteLine(MainDiagonalSumm(mass));
