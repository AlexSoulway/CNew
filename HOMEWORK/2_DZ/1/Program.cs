﻿//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("введите трехзначное число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(num / 10 % 10);