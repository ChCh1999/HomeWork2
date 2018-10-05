using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 0, 0 };
            Console.Write("输入一个数：");
            a[0] = Double.Parse(Console.ReadLine());
            Console.Write("再输入一个数：");
            a[1] = Double.Parse(Console.ReadLine());
            double x = a[0] * a[1];
            Console.WriteLine(a[0] + "与" + a[1] + "的乘积为 " + x);
        }
    }
}
