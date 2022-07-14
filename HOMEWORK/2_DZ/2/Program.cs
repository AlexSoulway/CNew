//Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int a = new Random().Next(100,999);
Console.WriteLine(a);

Console.Write(a / 100);
Console.Write(a % 10);