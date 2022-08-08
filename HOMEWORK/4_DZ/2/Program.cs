// 2. Напишите программу, которая принимает
//    на вход число и выдаёт сумму цифр в числе.


int SumNums(int num)
{
    int n_sum = 0;

    while (num > 0)
    {
        n_sum += num % 10;
        num /= 10;
    }
    return n_sum;
}
Console.WriteLine(SumNums(345));



// --------------------------------- 2 вариант

// int SumNums(int num)
// {
//     int n_sum = 0;

//     for (int i = num; num != 0; num /= 10)
//         n_sum += num % 10;

//     return n_sum;
// }

// Console.WriteLine(SumNums(452));
// Console.WriteLine(SumNums(82));
// Console.WriteLine(SumNums(9012));


// --------------------------------- 3 вариант
// https://shwanoff.ru/char-c-sharp/


// double DigitSum(int num)
// {
//     string n = num.ToString();
//     int length = n.Length;
//     double sum = 0;
    
//     for (int i = 0; i < length; i++)
//     {   
//         double m = char.GetNumericValue(n[i]);        
//         sum += m;
//     }

//     return sum;
// }

// int n = 123;

// Console.WriteLine(DigitSum(n));