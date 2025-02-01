using System;

namespace NSSumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int firstDivider = 3;
            int secondDivider = 5;
            int randomMinNumber = 0;
            int randomMaxNumber = 100;
            int number = random.Next(randomMinNumber,randomMaxNumber);
            int sum = 0;

            Console.WriteLine($"Рандомное число: { number} .");
            Console.WriteLine($"Числа, кратные {firstDivider} и {secondDivider} от числа {number} : ");

            for (int i = 0; i <= number; i++)
            {
                if(i % firstDivider == 0 || i % secondDivider == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            Console.WriteLine($"Сумма чисел кратных {firstDivider} и {secondDivider} от числа {number} = {sum} .");
        }
    }
}
