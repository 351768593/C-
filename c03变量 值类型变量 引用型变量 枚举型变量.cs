using System;

// https://docs.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/types-and-variables
namespace c3
{
    class C3
    {
        public static void run()
        {
            // 常用的变量类型
            
            // 有符号整数类型
            sbyte a1; // 8位 // 0 0000000
            short a2; // 16位
            int a3;   // 32位    
            long a4;  // 64位
            
            
            // 无符号整数类型
            byte a5; // 00000000
            ushort a6;
            uint a7;
            ulong a8;

            byte a11 = 250;
            byte a12 = 6;
            a11 = (byte)(a11 + a12);
            Console.WriteLine("a11=="+a11);

            int a13 = 256; // 1 0000 0000 
            byte a14 = (byte)a13; // 1(没了) 0000 0000 = 0
            int a15 = 257; // 1 0000 0001
            byte a16 = (byte)a15; // 1(没了) 0000 0001 = 1
            Console.WriteLine("a14==" + a14);
            Console.WriteLine("a16==" + a16);
            
            

            // 不同数据类型的范围
            //int a11 = int.MaxValue;
            //int a12 = int.MinValue;

            // 声明变量并为变量赋值
            int a9 = 0; // 赋值语句
            int a10 = 1;
            // 使用这个变量
            Console.WriteLine(a9);
            Console.WriteLine(a10);

            


            // 浮点数(小数)
            float b1; // 精确到7位

            double b2; // 精确到15到16位

            // 不做说明的话
            // 任何带小数点的数都是double类型
            // 任何不带小数点的数都是整型
            float f1 = 1.23f; // 在数字后跟上字母f 表示这是一个float值
            float f2 = 1.23F;
            double f3 = 4d; // 字母d表示这是一个double值
            double f4 = 5D;
            long f5 = 2l; // 字母l表示这是一个long值
            long f6 = 3L;

            // 布尔型 bool
            bool c1 = true;
            bool c2 = false;

            // 字符型
            char d1 = 'a';
            char d3 = '我';
            char d2 = 'A';

            
            // 引用型
            c1.C1 e1 = new c1.C1(); // 声明并初始化一个类为对象
            // 下面是分开写
            c1.C1 e2;
            e2 = new c1.C1(); // 使用new从类创建一个对象实例

            // 这时候e1是一个对象
            e1.a = 1; // 访问对象的成员变量
            e1.b = 2;
            int sum = e1.sum(); // 调用对象的成员方法 并将返回值存到一个变量里
            Console.WriteLine("调用对象的方法");
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Sum : " + e1.sum());

            // 引用型变量类似于c语言中的指针
            // 所以多个引用型变量可以指向同一个对象
            Console.WriteLine("多个引用型变量指向同一个对象");
            Console.WriteLine("e1 : " + e1.sum());
            e2 = e1; // 令e2指向e1
            e2.a = 3;
            e2.b = 4; // 这时对e2操作相当于对d1操作
            Console.WriteLine("e2 : " + e2.sum());
            Console.WriteLine("e1 : " + e1.sum());

            

            // 声明并使用枚举型变量
            week w1 = week.Mon;
            week w3 = week.Sat;
            week w2 = week.Tue;
            week w4 = w2;

            // 枚举型也是一种值类型
            e g1 = e.k1;
            e g2 = g1;
            g2 = e.k3; // 对e2操作不影响e1
            Console.WriteLine("g1: " + g1.ToString());
            Console.WriteLine("g2: " + g2.ToString());
            // 声明并使用结构体类型变量
            s s1;
            s1.key1 = 1;
            s1.key2 = 2;
            s s2 = s1;
            s2.key1 = 3;
            Console.WriteLine("S1: " + s1.key1 + "," + s1.key2);
            Console.WriteLine("S2: " + s2.key1 + "," + s2.key2);

            
        }

        // 枚举型 enum
        enum e // 声明一个枚举类型变量
        {
            k1, // 枚举类型
            k2,
            k3,
        }
        enum week
        {
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat,
            Sun,
        }
        // 结构体
        struct s // 类似于类的定义
        {
            public int key1;
            public int key2;
            public int sum()
            {
                return key1 + key2;
            }
        }
    }
}
/*
声明一些不同的变量
为变量赋不同的值
然后输出到控制台

    声明一些引用型变量
    给一部分引用变量指向对象（实例化对象），让另一部分引用变量“指向”这些对象
    然后对这些引用变量进行操作，看有什么影响
*/