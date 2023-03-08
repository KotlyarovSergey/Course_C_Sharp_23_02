// Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)

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
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

//int[] array = CreateRandomArray(10, 2, 14);
//int[] array = CreateRandomArray(10, 17, 1);

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное заначение элемента: ");
int minimum = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное заначение элемента: ");
int maximum = int.Parse(Console.ReadLine()!);

if (sizeArray <= 0)
    Console.WriteLine("Error! Размер массива должен быть не меньше 1!");
else if (minimum > maximum)
    Console.WriteLine("Error! Минимальное значение не может быть больше максимального!");
else
{
    int[] array = CreateRandomArray(sizeArray, minimum, maximum);
    PrintArray(array);
}