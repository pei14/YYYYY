using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _555555
{
    internal class Program
    {
        const double pi = 3.14159265359;
        static void Main(string[] args)
        {

            //1112410014_林霈琦
            Console.Write("請輸入圓的半徑: ");
            if (!double.TryParse(Console.ReadLine(), out double radius) || radius <= 0)
            {
                Console.WriteLine("半徑輸入錯誤，請輸入正數。");
                return;
            }

            Console.Write("請輸入圓週率的精度 (4 <= n <= 15): ");
            if (!int.TryParse(Console.ReadLine(), out int precision))
            {
                Console.WriteLine("精度輸入錯誤，請輸入整數。");
                return;
            }
            double pi = CountPi(precision);
            if (pi == -1)
            {
                Console.WriteLine("精度輸入超出範圍，程式結束。");
                return;
            }
            Console.WriteLine("使用精度 {0} 計算的圓週率: {1:g}", precision, pi);
            double circumference = GetCircumference(radius);
            Console.WriteLine("圓週長: {0:g}", circumference);
            double area = GetCircleArea(radius);
            Console.WriteLine("圓面積: {0:g}", area);
        }
        static double CountPi(int n)
        {
            if (n < 4 || n > 15) return -1;

            double pi = 0.0;
            for (int i = 0; i < n; i++)
            {
                pi += Math.Pow(-1, i) / (2 * i + 1);
            }
            return pi * 4;
        }
        static double GetCircumference(double r)
        {
            double pi = CountPi(15);
            return pi * r * 2;
        }
        static double GetCircleArea(double r)
        {
            double pi = CountPi(15);
            return pi * r * r;
        }
    }
}