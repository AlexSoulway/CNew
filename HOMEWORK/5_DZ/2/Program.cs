// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 89, 6] -> 0
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

    for (int i = 0; i < arr.Length; i = i + 2)
    {
        
        {
            count += arr[i];
        }        
    }
    return count;
}

int[] arr_1 = RandArray(8, 10, 20);
Print(arr_1);
Console.WriteLine(Num(arr_1));