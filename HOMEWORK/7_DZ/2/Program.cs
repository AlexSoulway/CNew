// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],6} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[8, 8];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(1, 20);
        }

    }
    return arr;
}

void Check(int[,] arr, int k1, int k2)
{
    if (k1 <= 8 && k2 <= 8)
    {
        Console.WriteLine($"{arr[k1, k2]}");
    }
    else
    {
        System.Console.WriteLine("no");
    }
}

int[,] arr_1 = MassNums(8, 8, 1, 11);
Print(arr_1);

Console.WriteLine("введите номер строки");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("arr[" + k1 + ", " + k2 + "] = " + arr_1[k1, k2]);
Check(arr_1, k1, k2);



// void Print(int[,] arr)
// {
//     int row_size = arr.GetLength(0);
//     int column_size = arr.GetLength(1);

//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//             Console.Write($" {arr[i, j]} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] MassNums(int row, int column, int from, int to)
// {
//     int[,] arr = new int[row, column];

//     for (int i = 0; i < row; i++)
//         for (int j = 0; j < column; j++)
//             arr[i, j] = new Random().Next(from, to);
//     return arr;
// }

// string FindElement(int[,] arr, int f, int s)
// {
//     int row = arr.GetLength(0);
//     int column = arr.GetLength(1);

//     if (f > row || f <= 0 || s > column || s <= 0)
//         return $"{f} {s} -> not in the array";
//     return $"arr[{f}, {s}] = {arr[f - 1, s - 1]} -> is in the array";
// }

// Console.Write("Enter the line position: ");
// int first = int.Parse(Console.ReadLine());
// Console.Write("Enter the column position: ");
// int second = int.Parse(Console.ReadLine());

// int[,] arr_1 = MassNums(3, 4, 1, 11);
// Print(arr_1);

// Console.WriteLine(FindElement(arr_1, first, second));




