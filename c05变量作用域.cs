using System;

namespace c5
{
    class Human
    {
        public byte age;
        public bool sex;

        public const int legs=2;

        public static void say1()
        {
            Console.WriteLine("我是一个人");
        }

        public void say()
        {
            int age2 = 123;

            Console.WriteLine("我今年"+age+"岁");
        }
        public void say3()
        {
            Console.WriteLine("我有"+legs+"条腿");
        }
        
    }
}