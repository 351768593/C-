using System;

namespace c17
{
    class C17
    {
        class B { }
        public static void exm1() // 声明一个数组
        {
            int[] num;
        }
        public static void exm2() // 初始化一个数组
        {
            int[] nums = new int[123];

            int len2 = 456;
            int[] nums2 = new int[len2];

            int[] nums3;
            int len3 = 789;
            nums3 = new int[len3];
        }
        public static void exm3() // 数组的列表初始化方式
        {
            int[] nums0 = new int[0];
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 1, 2, 3, 4, 5 };
            int[] nums3 = new int[] { 6, 7, 8, 9, 10, };
        }
        public static void exm4() // 先声明并初始化一个大数组 然后按需使用
        {
            int[] nums = new int[100];
            int i = 0;
            while(true)
            {
                bool isNum = int.TryParse(Console.ReadLine(), out int num);
                if(isNum && num!=0 && i<nums.Length)
                {
                    nums[i] = num;
                    i++;
                }
                else
                {
                    break;
                }
            }
            int j = 0;
            while(nums[j]!=0)
            {
                Console.WriteLine("nums[" + j + "]==" + nums[j]);
            }
        }
        public static void exm5() // 根据需要 动态初始化数组
        {
            int[] nums;
            bool isNum = int.TryParse(Console.ReadLine(), out int num);
            if (isNum)
            {
                nums = new int[num];
            }
            else
            {
                nums = new int[123];
            }
        }
        class C { public int num; }
        public static void exm6() // 引用型数组
        {
            // 数组本身也是一个引用型变量 是一个对象
            C[] cs1; // 仅声明一个数组型引用 这时数组型引用(cs1)指向null
            C[] cs2 = new C[10]; // 声明了一个数组型引用 初始化了一个长度为10的数组 并将引用指向了这个数组
                                 // 但是这个时候数组里的10个引用都指向null

            C[] cs3 = new C[10];
            for(int i=0;i<10;i++)
            {
                cs3[i] = new C(); // 为数组里每个引用指向一个C对象
            }
        }
        public static void exm7() // 引用型数组的列表初始化
        {
            C[] cs = new C[] { new C(), new C(), null, new C(), };
        }

        public static void run() // 对数组进行读写
        {
            int[] nums = new int[10];
            nums[123456] = 1;
            Console.WriteLine(nums[10]);
        }
    }
}