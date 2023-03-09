// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] DoubleRandomArray(int size, double min, double max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (max - min) + min;
    }

    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]:F2} ");
    }
    Console.WriteLine("\b]");
}

double Distinction(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    Console.WriteLine($"Max = {max:F2} Min = {min:F2}");
    return max - min;
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);
//int sizeArray = 123;

Console.Write("Введите минимальное заначение элемента: ");
double minimum = double.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное заначение элемента: ");
double maximum = double.Parse(Console.ReadLine()!);

double[] array = DoubleRandomArray(sizeArray, minimum, maximum);
PrintArray(array);
double distinct = Distinction(array);
Console.WriteLine($"Разница = {distinct:F2}"); 