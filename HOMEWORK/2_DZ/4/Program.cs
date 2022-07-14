//Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели и мы скажем выходной это или нет");
int a = int.Parse(Console.ReadLine());
if (a == 1)
Console.WriteLine("Нет");
else if ( a == 2)
Console.WriteLine("Нет");
else if ( a == 3)
Console.WriteLine("Нет");
else if ( a == 4)
Console.WriteLine("Нет");
else if ( a == 5)
Console.WriteLine("Нет");
else if ( a == 6)
Console.WriteLine("Да");
else if ( a == 7)
Console.WriteLine("Да");
else 
Console.WriteLine("Нет такого дня, Вам определенно пора отдохнуть...");