using System;

namespace c19
{
    class C19
    {
        public static void exm1() // 交换值类型
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("a== " + a + " b==" + b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a== " + a + " b==" + b);
        }
        public static void exm1_2() // 交换值类型 错误的做法
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("a== " + a + " b==" + b);
            a = b;
            b = a;
            Console.WriteLine("a== " + a + " b==" + b);
        }

        class C { public int num; }
        public static void exm2() // 交换引用型
        {
            C c1 = new C(); c1.num = 1;
            C c2 = new C(); c2.num = 2;
            C c3 = c1;
            Console.WriteLine("c1.num==" + c1.num + " c2.num==" + c2.num + " c3.num==" + c3.num);

            C ctemp = c1;
            c1 = c2;
            c2 = ctemp;
            Console.WriteLine("c1.num==" + c1.num + " c2.num==" + c2.num + " c3.num==" + c3.num);
        }

        public static void sort()
        {
            int temp = 0;
            int[] nums = { 23, 44, 66, 76, 98, 11, 3, 9, 7 };
            Console.WriteLine("排序前的数组：");
            foreach (int item in nums)
            {
                Console.Write(item + "");
            }
            Console.WriteLine();


            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine("排序后的数组：");
            foreach (int item in nums)
            {
                Console.Write(item + "");
            }
            Console.WriteLine();
        }
    }
}