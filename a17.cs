using System;

namespace a17
{
    class C17
    {
        public static void run()
        {
            int[] nums = new int[] {1,3,5,3,2,5,6,7,8, };
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            for(int i=0;i<nums.Length;i++)
            {
                sum += nums[i];
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];
            }
            foreach(int num in nums)
            {
                sum += num;
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }
            int avr= sum/ nums.Length;
        }

        public static void t2()
        {
            /*3. 输出斐波那契数列前10项
            斐波那契数列: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 ...
            从第3项开始, 每一项都等于前两项之和*/
            int[] f = new int[10];
            f[0] = f[1] = 1;
            for(int i=2;i<10;i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            foreach(int num in f)
            {
                Console.Write(num + "\t");
            }
        }
    }
}