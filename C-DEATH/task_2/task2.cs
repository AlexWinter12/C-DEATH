using System;

namespace SumIntegerNumbers
{
    class EnteringIntegers
    {
        public static int Entering(string integers)
        {
            Console.Write(integers);
            return Convert.ToInt32(Console.ReadLine());
        }
    }

    class SumIntegers
    {
        public static int Sum(int integers_1, int integers_2)
        {
            return integers_1 + integers_2;
        }
    }

    class Conclusion
    {
        public static void Final()
        {
            int integers_1 = EnteringIntegers.Entering("Первое число");
            int integers_2 = EnteringIntegers.Entering("Второе число");
            int sum = SumIntegers.Sum(integers_1,integers_2);
            Console.WriteLine($"Результат: {sum}");
        }
    }

    class Program
    {
        public static void Main()
        {
            Conclusion.Final();
        }
    }
}

    