using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入数组的元素个数：");
            int nCount = int.Parse(Console.ReadLine());

            //初始化数组
            int[] NumArray;
            int SumOfArrey;
            int MaxNum;
            int MinNum;
            double averageOfNum;
            SumOfArrey = 0;
            NumArray = new int[nCount];

            //输入数组
            Console.WriteLine("输入"+nCount+"个整数:");
            for (int i = 0; i < nCount; i++)
            {
                Console.Write("第" + (i+1) + "个:  ");
                NumArray[i] = int.Parse(Console.ReadLine());
            }

            //处理数据
            MinNum = NumArray[0];
            MaxNum = NumArray[0];
            for (int i = 0; i < nCount; i++)
            {
                SumOfArrey += NumArray[i];
                if (NumArray[i] > MaxNum)
                    MaxNum = NumArray[i];
                if (NumArray[i] < MinNum)
                    MinNum = NumArray[i];
            }
            averageOfNum = SumOfArrey / nCount;

            //输出数据
            Console.WriteLine("数组的最大值为： " + MaxNum + ";");
            Console.WriteLine("数组的最小值为： " + MinNum + ";");
            Console.WriteLine("数组的平均值为： " + averageOfNum + ";");
            Console.WriteLine("数组的和为： " + SumOfArrey + ";");
        }
    }
}
