// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.





 double[,] arr = {{3, 2, 7, 2},
               {9, 1, 3, 4},
               {7, 2, 3, 4},
               {3, 5, 2, 1}};
double a = (arr[0, 0] + arr[1, 0] + arr[2, 0] + arr[3, 0]) / 4;
double b = (arr[0, 1] + arr[1, 1] + arr[2, 1] + arr[3, 1]) / 4;
double c = (arr[0, 2] + arr[1, 2] + arr[2, 2] + arr[3, 2]) / 4;
double d = (arr[0, 3] + arr[1, 3] + arr[2, 3] + arr[3, 3]) / 4;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);






// int[,] arr_1 = MassNums(4, 4, 1, 11);
// Print(arr_1);
// Console.WriteLine(a);




// Console.WriteLine("arr[" + k1 + ", " + k2 + "] = " + arr_1[k1, k2]);
// // Check(arr_1,k1, k2); 







