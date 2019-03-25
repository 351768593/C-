using System;

namespace c4
{
    class C4
    {
        public static void run()
        {
            // 隐式类型转换
            // 显式类型转换

            // 类型转换类似于赋值
            // 数据范围小的变量可以直接隐式转换为数据范围大的变量
            int a = 1;
            long b = 2;
            b = a;
            // a = b; // 不能把大的数据隐式转换为小的数据

            int a1 = (short)123L;
            long b1 = int.MaxValue;



            // 显式类型转换
            a = (int)b; // 写一个小括号 然后里面写要转换成的数据类型

            byte c = 0;
            short d = 0;
            c = (byte)d;

            // 根据需要定义变量类型
            //int g;
            //// g = int.MaxValue + 1;
            //g = int.MaxValue;
            //g++; // 溢出
            //Console.WriteLine(g);

            byte b11 = byte.MaxValue;
            b11=(byte)(b11+1);
            Console.WriteLine(b11);
        }
    }
}