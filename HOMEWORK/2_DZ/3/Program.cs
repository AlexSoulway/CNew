//Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());

    if (n > 100 && n < 1000)
    Console.WriteLine(n % 10);
    else if (n < 100)
    Console.WriteLine("нет третьей цифры");
    else if (n > 1000 && n < 10000)
    Console.WriteLine(n / 10 % 10);
     else if (n > 10000 && n < 100000)
    Console.WriteLine(n / 100 % 10);
     else if (n > 100000 && n < 1000000)
    Console.WriteLine(n / 1000 % 10);
    
    
    
    Console.WriteLine();