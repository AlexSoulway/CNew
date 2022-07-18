
Console.WriteLine("Введите пятизначное число и мы скажем является ли оно палиондромом");
int num = int.Parse(Console.ReadLine());

int a = Convert.ToInt32(num / 10000);
int b = Convert.ToInt32(num / 1000 % 10);
int c = Convert.ToInt32(num / 10 % 10);
int d = Convert.ToInt32(num % 10);
if(a == d || b == c)
{
 Console.WriteLine("da");  
}
else
{
    Console.WriteLine("no");
}
