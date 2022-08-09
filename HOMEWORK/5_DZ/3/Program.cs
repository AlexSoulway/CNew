// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] arr = { 3, 5, 45, 54, 54, 34, 77, 45, 88 };

int minValue = arr[0];
int maxValue = arr[0];

for(int i = 1; i < arr.Length; i++)
if (arr[i] < minValue)
{
    minValue = arr[i];
}
for(int i = 1; i < arr.Length; i++)
if (arr[i] > maxValue)
{
    maxValue = arr[i];
}
int Result = (maxValue - minValue);

Console.WriteLine(minValue);
Console.WriteLine(maxValue);
Console.WriteLine(Result);

