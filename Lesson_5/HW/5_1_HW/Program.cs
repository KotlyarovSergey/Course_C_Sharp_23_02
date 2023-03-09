﻿// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

int CountMassElements(int[] array, bool even)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(even && array[i] % 2 == 0) count++;
        else if(!even && array[i] % 2 != 0) count++;

        /*
        if (even)
        {
            if (array[i] % 2 == 0) count++;
        }
        else
        {
            if (array[i] % 2 == 1) count++;
        }
        */

        /*
        if (array[i] % 2 == 0)
        {
            if (even) count++;
        }
        else
        {
            if (!even) count++;
        }
        */
    }
    return count;
}


Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);
//int sizeArray = 123;

//Console.Write("Введите минимальное заначение элемента: ");
//int minimum = int.Parse(Console.ReadLine()!);
int minimum = 100;

//Console.Write("Введите максимальное заначение элемента: ");
//int maximum = int.Parse(Console.ReadLine()!);
int maximum = 999;

int[] array = CreateRandomArray(sizeArray, minimum, maximum);
PrintArray(array);

int even = CountMassElements(array, true);
int uneven = CountMassElements(array, false);
Console.WriteLine($"Четных: {even}");
Console.WriteLine($"Нечетных: {uneven}");

