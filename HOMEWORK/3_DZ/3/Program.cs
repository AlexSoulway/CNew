// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Searching (int a)
{
    int b = 1;
    while (b <= a)
    {
        Console.WriteLine(Math.Pow(b, 3));
        b = b+1;
    }
}
Searching(5);