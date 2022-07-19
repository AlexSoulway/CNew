// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = Convert.ToInt32(Console.ReadLine());
// void Searching (int a)
// {
    int b = 1;
    while (b <= n)
    {
        Console.WriteLine(Math.Pow(b, 3));
        b = b+1;
    }
    Console.WriteLine();
// }
// Searching(5);