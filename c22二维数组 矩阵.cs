using System;

namespace c22
{
    class C22
    {
        public static void run()
        {
            int[,] nums1 = new int[3, 4];
            // int[3,4] 意思是有一个二维数组 内有3个长度为4的一维数组
            int[,] nums2 = new int[3, 4] { { 1, 2, 3, 4, }, { 5, 6, 7, 8, }, { 9, 10, 11, 12, } };
            int[,] nums3 = new int[,] { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9 } };
            int x = 3;
            int y = 4;
            int[,] nums4=new int[x,y];
            int[] nums = new int[10];
            
            Console.WriteLine("nums2[1,0] :s ");
            Console.WriteLine(nums2[1,0]);


            Console.WriteLine("nums2.Rank : " + nums2.Rank);
            Console.WriteLine("nums2.Length : " + nums2.Length);
            Console.WriteLine("nums2 : ");
            foreach(int num in nums2)
            {
                Console.WriteLine(""+num);
            }

            int[,,] nums6 = new int[2, 3, 4];
            Console.WriteLine("nums6.Rank : " + nums6.Rank);
            Console.WriteLine("nums26.Length : " + nums6.Length);
            Console.WriteLine("nums6 : ");
            for (int a=0;a<2;a++)
            {
                for(int b=0;b<3;b++)
                {
                    for(int c=0;c<4;c++)
                    {
                        nums6[a, b, c] = a * b * c;
                    }
                }
            }
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        Console.Write(nums6[a, b, c]+"\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}