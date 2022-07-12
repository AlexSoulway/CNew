Console.WriteLine("Введи 3 числа и мы тебе скажем какое из них больше");
            int a, b, c, max;
            Console.WriteLine("Введи первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи второе число - ");
            b = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Введи третье число - ");
            c = Convert.ToInt32(Console.ReadLine());
             max = a;
           



      
if (b > a)
    max = b;
if (c > max)
    max = c;
             Console.WriteLine($"Самое большое число {max}");