using System;

namespace c21
{
    class C21
    {
        public static void run()
        {
            int[][] nums1; // 声明一个交错数组
            int[][] nums2 = new int[3][];
            for(int a=0;a<3;a++)
            {
                nums2[a] = new int[4];
            }

            Console.WriteLine("子数组长度相等的交错数组 :");
            Console.WriteLine("for遍历");
            for(int a=0;a<3;a++)
            {
                for(int b=0;b<4;b++)
                {
                    nums2[a][b] = a * b; // 向数组写数组
                    Console.Write(nums2[a][b]+"\t"); // 从数组读数据
                }
                Console.WriteLine();
            }

            Console.WriteLine("foreach遍历");
            foreach(int[] line in nums2)
            {
                foreach(int num in line)
                {
                    Console.Write(num+"\t"); // 从数组读数据
                }
                Console.WriteLine();
            }


            Console.WriteLine("子数组长度 不 相等的交错数组 :");
            int[][] nums3;
            nums3 = new int[4][];
            for(int a=0;a<4;a++)
            {
                nums3[a] = new int[a + 1]; // 初始化长度不同的子数组
                for(int b=0;b<a+1;b++)
                {
                    nums3[a][b] = a * b;
                    Console.Write(nums3[a][b] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}