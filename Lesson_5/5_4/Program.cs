// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний
//    и т.д. Результат запишите в новом массиве.

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
        Console.Write($"{arr[i],3} ");
    }
    Console.WriteLine("\b]");
}


void MultPairs(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        Console.Write($"{array[i] * array[array.Length - i - 1]} ");
    }
    if (array.Length % 2 > 0)
        Console.WriteLine(array[array.Length / 2]);
}

int[] MultiMas(int[] arr)
{
    int size = arr.Length;
    int[] newMass = new int[size / 2 + size % 2];
    for (int i = 0; i < size / 2; i++)
    {
        newMass[i] = arr[i] * arr[size - 1 - i];
    }
    if (size % 2 == 1)
    {
        newMass[newMass.Length - 1] = arr[arr.Length / 2];
    }
    return newMass;
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

MultPairs(array);
int[] arrary2 = MultiMas(array);
PrintArray(arrary2);