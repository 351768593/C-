using System;
using System.Collections;

namespace a21_24
{
    struct Order
    {
        public string bid;
        public string acid;
        public Order(string bid,string acid)
        {
            this.bid = bid;
            this.acid = acid;
        }
    }

    class AC { }

    class A21_24
    {
        public static void p(int[][] lines)
        {
            foreach (int[] line in lines)
            {
                foreach (int num in line)
                {
                    Console.Write(num + "\t");
                }
                Console.WriteLine();
            }
        }


        public static void t1()
        {
            int N = 8;
            int[][] nums = new int[N][];
            for(int i=0;i<N;i++)
            {
                nums[i] = new int[i + 1];
            }

            nums[0][0] = 1; // 给第0行元素赋初值1
            for(int i=1;i<N;i++) // 一共有n行 循环从第1行开始执行
            { // i代表第几行
                for(int j=0;j<i+1;j++)  // 第n行有n+1个元素(比如第0行有1个元素)
                {                       // 每行执行当前行数+1次循环
                    if (j == 0) // 每行的第0个元素
                    {
                        nums[i][j] = nums[i - 1][j]; // 等于上一行的第0个元素
                    }
                    else if (j == i) // 每行的最后一个元素
                    {
                        nums[i][j] = nums[i - 1][j - 1]; // 等于上一行最后一个元素
                        // nums[i][j] = 1; // 直接等于1
                    } // 假如当前是第4行 最后一个元素就是nums[4][4] 上一行的最后一个元素就是nums[3][3]
                    else // 行里的元素
                    {
                        nums[i][j] = nums[i - 1][j - 1] + nums[i - 1][j];
                    }
                }
            }

            p(nums);
        }
        
    }

}