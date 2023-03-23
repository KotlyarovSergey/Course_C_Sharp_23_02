// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
int GetUserDataInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GetUserMatrix()
{
    int rows = GetUserDataInteger("Количество строк: ");
    int columns = GetUserDataInteger("Количество столбцов: ");
    //int start = GetUserDataInteger("Минимальный элемент: ");
    //int stop = GetUserDataInteger("Максимальный элемент: ");

    int[,] matrix = RandomArray(rows, columns, 1, 20);
    return matrix;
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

int[,] RandomArray(int rows, int columns, int minItem, int maxItem)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minItem, maxItem + 1);
    return array;
}

bool CheckAgerrement(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0)) return true;
    else return false;
}


int CalculateItem(int[,] matrixA, int[,] matrixB, int row, int column)
{
    int res = 0;
    //return row * 10 + column;
    for (int i = 0; i < matrixA.GetLength(1); i++)
    {
        res += matrixA[row, i] * matrixB[i, column];
    }
    return res;
}


int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixC.GetLongLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = CalculateItem(matrixA, matrixB, i, j);
        }
    }

    return matrixC;
}





Console.WriteLine("Создаем матрицу A:");
int[,] matrixA = GetUserMatrix();
Print2dArray(matrixA);


Console.WriteLine("Создаем матрицу B:");
int[,] matrixB = GetUserMatrix();
Print2dArray(matrixB);


if (!CheckAgerrement(matrixA, matrixB))
{
    Console.WriteLine("Произведение невозможно, т.к. матрицы не согласованые.");
    return;
}


Console.WriteLine("\nРезультат умножения:");
int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
Print2dArray(matrixC);

