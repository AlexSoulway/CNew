// 3. Задайте две матрицы. Напишите программу,
//    которая будет находить произведение двух матриц.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] Nums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}
int[,] Matrixmultiply(int[,] arr_first, int[,] arr_second)
{
    int row_size = arr_first.GetLength(0);
    int column_size = arr_first.GetLength(1);
    int[,] matrix = new int[row_size, column_size];

    if (column_size != arr_second.GetLength(0)) return matrix;
    else if (column_size == arr_second.GetLength(0))
        matrix = new int[row_size, row_size];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < row_size; j++)
        {
            for (int p = 0; p < column_size; p++)
                matrix[i, j] += arr_first[i, p] * arr_second[p, j];
        }
    }
    return matrix;
}


Console.Write("Введите количество строк 1: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1: ");
int column_1 = int.Parse(Console.ReadLine());

Console.Write("EВведите количество строк  2: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_1 = Nums(row_1, column_1, 0, 5);
Print(arr_1);
int[,] arr_2 = Nums(row_2, column_2, 0, 5);
Print(arr_2);

int[,] res_matrix = Matrixmultiply(arr_1, arr_2);
Print(res_matrix);

