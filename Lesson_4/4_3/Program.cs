// Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами 
// в случайном порядке
// [1,0,1,1,0,1,0,0]

int[] RandomArray(int n)
{
    int[] array = new int[n];
    for(int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

Console.Write("Количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] arr = RandomArray(n);


for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}