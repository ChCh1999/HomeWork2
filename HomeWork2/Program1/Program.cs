using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入一个数求其全部素数因子
            //输入数据
            Console.Write("输入一个正整数：");
            int Num = int.Parse(Console.ReadLine());
            int Factor = 2;
            Console.Write(Num + "的素数因子有：");
            while (Num != 1)
            {
                if (Num % Factor == 0)
                    Console.Write(Factor + "、");
                while (Num % Factor == 0)
                {
                    Num = Num / Factor;
                }
                Factor++;
            }
        }
    }
}
