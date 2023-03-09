// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b]");
}

int SumUneventPosition(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);
//int sizeArray = 123;

Console.Write("Введите минимальное заначение элемента: ");
int minimum = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное заначение элемента: ");
int maximum = int.Parse(Console.ReadLine()!);

int[] array = CreateRandomArray(sizeArray, minimum, maximum);
PrintArray(array);

int summ = SumUneventPosition(array);
Console.WriteLine("Сумма элементов на нечётных позициях = {0}", summ);