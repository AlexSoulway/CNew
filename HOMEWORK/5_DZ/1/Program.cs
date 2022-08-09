// // Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] RandArray(int size, int from, int to)
{
    int[] arr = new int[8];

    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int Num(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }        
    }
    return count;
}

int[] arr_1 = RandArray(8, 100, 1000);
Print(arr_1);
Console.WriteLine(Num(arr_1));

