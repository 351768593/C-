using System;

namespace c17
{
    class C17_3 // 数组排序
    {
        public static void run()
        {
            int[] nums = new int[] { 4, 5, 6, 3, 2, 1, 7, 9, 8 };
            p(nums);
            

            Array.Sort(nums);
            p(nums);
            


            Array.Reverse(nums);
            p(nums);

            Console.WriteLine("Array.IndexOf(nums, 5) : "+ Array.IndexOf(nums, 5));
        }

        public static void p(int[] nums) // 用来输出数组里的内容
        {
            foreach (int num in nums)
                Console.Write(num + "\t");
            Console.WriteLine("\n\n\n");
        }
    }
}