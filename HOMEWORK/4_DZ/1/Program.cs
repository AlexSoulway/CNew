// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Method(int num)
{
    int AllSum = 1;
    for (int i = 1; i <= num; i++)
        AllSum = AllSum * i;
    return AllSum;

}
Console.WriteLine(Method(4));



// Console.ReadLine(a);
// Console.ReadLine(b);