using System;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите десятичное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Двоичное представление числа {n} стандартным средством:\t{Convert.ToString(n, 2)}");
            Console.WriteLine($"Двоичное представление числа {n}:\t\t\t{ToBin(n)}");
        }

        static string ToBin(int n)
        {
            int num = 0;
            string result = string.Empty;
            string tmp = string.Empty;
            while(n > 0)
            {
                num = n % 2;
                n /= 2;
                tmp += Convert.ToString(num);
            }
            for (int i = tmp.Length - 1; i >= 0; i--)
            {
                result += tmp[i];
            }
            return result;
        }
    }
}
