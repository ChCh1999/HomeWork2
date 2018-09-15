using System;
using System.Collections;
namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化2~100的数组
            int[] AllNum;
            AllNum = new int[99];
            for(int i = 0; i < 99; i++)
            {
                AllNum[i] = i + 2;
            }

            //筛选
            for(int i = 2; i < 100; i++)
            {
                for(int j = 0; j < 99; j++)
                {
                    if (AllNum[j] % i == 0&&AllNum[j]!=i)
                        AllNum[j] = 0;
                }
                
            }

            //输出100以内的素数
            foreach(int i in AllNum)
            {
                if (i != 0)
                    Console.Write(i + " 、");
            }
        }
    }
}
