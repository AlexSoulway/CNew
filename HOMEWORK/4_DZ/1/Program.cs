// 1. Напишите цикл, который принимает на вход два числа (A и B)
//    и возводит число A в натуральную степень B.


int PowNum(int a, int b)
{   
    int n_pow = a;
    
    for (int i = 2; i <= b; i++)
    {
        n_pow *= a; 
    }  
    return n_pow;  
}

Console.WriteLine("Enter first number: ");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine(PowNum(num_1, num_2));

Console.WriteLine(PowNum(2, 4));