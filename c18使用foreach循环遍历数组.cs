using System;

namespace c18
{
    class C { public int num; }
    class C18
    {
        public static void exm1()
        {
            int[] nums = new int[10];
            C[] cs = new C[10];
            for(int i=0;i<nums.Length;i++) // 初始化两个数组
            {
                nums[i] = i;
                cs[i] = new C(); // 把数组里某一个引用 指向到一个对象
                cs[i].num = i;
            }

            foreach(int num in nums) // 输出数组里的值
            {
                Console.WriteLine(num);
            }
            foreach(C c in cs) // 输出对象的成员属性
            {
                Console.WriteLine(c.num); 
            }

            foreach(int num in nums)
            {
                // num = 10; // 值类型数组不能用foreach循环赋值
            }
            foreach(C c in cs)
            {
                c.num = 1; // 引用型数组可以
            }
        }
    }
}