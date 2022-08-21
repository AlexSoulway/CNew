// 2. Задайте прямоугольный двумерный массив. Напишите программу,
//    которая будет находить строку с наименьшей суммой элементов.


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

void MinSumrow(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int quantity = 1000;
    int num;
    int min = 0;

    for (int i = 0; i < row_size; i++)
    {   
        num = 0;
        for (int j = 0; j < column_size; j++)
            num += arr[i, j];
            Console.Write($"{num, 4} ");            

        if (quantity > num)
        {
           quantity = num;
            min = i;
        }
    }
    Console.WriteLine();
    Console.Write($"The row with the lowest amount per position - {min + 1}");
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Nums(row, column, 0, 10);
Print(arr_1);

MinSumrow(arr_1);
