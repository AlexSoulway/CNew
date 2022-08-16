// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// 3. Задайте двумерный массив из целых чисел.
//    Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void ArithmeticMean(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double res;

    for (int i = 0; i < column; i++)
    {
        res = 0;
        for (int j = 0; j < row; j++) res += arr[j, i];
        Console.Write($"{Math.Round(res / row, 2)}; ");
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 6);
Print(arr_1);

ArithmeticMean(arr_1);







//  double[,] arr = {{3, 2, 7, 2},
//                   {9, 1, 3, 4},
//                   {7, 2, 3, 4},
//                   {3, 5, 2, 1}};
// double a = (arr[0, 0] + arr[1, 0] + arr[2, 0] + arr[3, 0]) / 4;
// double b = (arr[0, 1] + arr[1, 1] + arr[2, 1] + arr[3, 1]) / 4;
// double c = (arr[0, 2] + arr[1, 2] + arr[2, 2] + arr[3, 2]) / 4;
// double d = (arr[0, 3] + arr[1, 3] + arr[2, 3] + arr[3, 3]) / 4;
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(d);
















