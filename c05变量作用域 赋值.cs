using System;

namespace c5
{
    class C5
    {
        int a = 100; // 作用域为整个类
        int b = 101;

        public void run()
        {
            int a = 0; // 又声明了一个名字是a的变量
            int b = 1;
            a = b; // 就近原则 这里操作的是方法体里的a和b 不是类里的a和b
            Console.WriteLine(a);
        }
        public void run2()
        {
            int a = 10;
            int b = 11; // 就近原则
            Console.WriteLine(a);
        }
        public void run3()
        {
            a = b; // 这里操作的是类里的变量
            Console.WriteLine(a);
        }
    }
}