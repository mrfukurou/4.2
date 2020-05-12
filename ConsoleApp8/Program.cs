using System;
using System.Threading;

namespace ConsoleApp8
{
    class Program
    {
        static void N(int n, int a)
        {
            if (a <= n)
            {
                for (int j = 1; j <= a; j++)
                    Console.Write(a + " ");
                Console.WriteLine();
                N(n, a + 1);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите n: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                { N(n, 1); }
                else Console.Write("Число должно быть больше 0!");
            }
            catch { Console.Write("Некорректный ввод!"); }
        }
        
    }
}
