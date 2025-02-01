using System;

namespace NSSumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int threeDivider = 3;
            int fiveDivider = 5;
            int number = random.Next(0,100);
            int sum = 0;

            Console.WriteLine($"Рандомное число: { number} .");
            Console.WriteLine($"Числа, кратные {threeDivider} и {fiveDivider} от числа {number} : ");

            for (int i = 0; i < number; i++)
            {
                if(i % threeDivider == 0 || i % fiveDivider == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма чисел кратных {threeDivider} и {fiveDivider} от числа {number} = {sum} .");
        }
    }
}
