// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        //array[i] = new Random().Next(1, 100);
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        //Console.Write(arr[i]);
        //if (i < arr.Length - 1) Console.Write(", ");
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

void MassSearchNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            Console.WriteLine("Yes");
            return;
        }
    }
    Console.WriteLine("No");
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное заначение элемента: ");
int minimum = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное заначение элемента: ");
int maximum = int.Parse(Console.ReadLine()!);

int[] array = CreateRandomArray(sizeArray, minimum, maximum);
PrintArray(array);

Console.Write("Введите искомое: ");
int findedNum = int.Parse(Console.ReadLine()!);
MassSearchNum(array, findedNum);