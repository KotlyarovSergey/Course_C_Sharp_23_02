// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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
        //Console.Write(arr[i]);
        //if (i < arr.Length - 1) Console.Write(", ");
        Console.Write($"{arr[i], 3} ");
    }
    Console.WriteLine("\b]");
}


int CountRangeMass(int[] array, int min, int max)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max)
            count++;
    }

    return count;
}


//Console.Write("Введите размер массива: ");
//int sizeArray = int.Parse(Console.ReadLine()!);
//int sizeArray = 12;
int sizeArray = 123;

Console.Write("Введите минимальное заначение элемента: ");
int minimum = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное заначение элемента: ");
int maximum = int.Parse(Console.ReadLine()!);

int[] array = CreateRandomArray(sizeArray, minimum, maximum);
PrintArray(array);

int cnt = CountRangeMass(array, 10, 99);
Console.WriteLine(cnt);