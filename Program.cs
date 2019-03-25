using System;
using System.Collections;
using e;
using System.IO;
using c34;
// using Human = c5.Human;


// using c11; // 声明使用命名空间

namespace Cs
{
    class Program
    {
        public static void run()
        {
            Console.WriteLine("run");
        }
        public static void run(int a)
        {
            Console.WriteLine("run "+a);
        }
        /*
         每个c#程序都要有一个入口 也就是
         程序从这里开始运行
        */

        public delegate void fun();
        public static void fun1() { Console.WriteLine("fun1"); }
        public static void fun2() { Console.WriteLine("fun2"); }
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1000; i <= 9999; i++)
            {
                if (IsHuiWen(i))
                {
                    count++;
                }
            }

            Console.WriteLine("count==" + count); Console.ReadLine(); // 防止程序直接退出
        }
        public static bool IsHuiWen(int i)
        {
            int i1 = i % 10;
            int i2 = i % 100 / 10;
            int i3 = i % 1000 / 100;
            int i4 = i / 1000;
            if (i1 == i4 && i2 == i3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}

