using System;

namespace Лабораторная
{
    class Program
    {
        static void Main(string[] args)
        {
            double D; double Res1; double Res2;
            Console.WriteLine("Введите число х, который будет умножен на x в квадрате");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y, который будет умножен на х");
            int y = Convert.ToInt32(Console.ReadLine());
            Convert.ToInt32(y);
            Console.WriteLine("Введите число z, который будет свободным членом");
            int z = Convert.ToInt32(Console.ReadLine());
            D = (y * y) - 4 * x * z;
            D = Math.Sqrt(D);
            Res1 = (-y + D) / (2 * x); Res2 = (-y - D) / (2 * x);
            Console.WriteLine("X1 = {0}, X2 = {1}", Res1, Res2);



        }
    }
}
