using System;

namespace c8
{
    class Human
    {
        public int age;
        public bool sex;
        public Human() // 重写默认构造函数
        {
            Console.WriteLine("Human 类 默认构造函数");
            age = 30;
            sex = false;
        }
        public Human(int ageIn, bool sexIn) // 自定义构造函数
        {
            Console.WriteLine("Human类 自定义构造函数");
            age = ageIn;
            sex = sexIn;
        }
        public Human(int age1,int age2,bool sexIn)
        {
            Console.WriteLine("Human类 自定义构造函数 2");
            age = age1 + age2;
            sex = sexIn;
        }

        public void say()
        {
            Console.WriteLine("我是"+(sex?"男性": "女性") +", 今年"+age+"岁");
        }
        public void say2(int a,int b)
        {
            Console.WriteLine(a+b);
        }
    }
    class Human2
    {
        public int age;
        public bool sex;

        public void say()
        {
            Console.WriteLine("我是" + (sex ? "男性" : "女性") + ", 今年" + age + "岁");
        }
    }

    class C8_2
    {
        public static void run()
        {
            Human h1 = new Human(); // 使用默认构造函数
            h1.say();
            int a = 123;
            Human h2 = new Human(a, false); // 使用自定义构造函数
            Human h3 = new Human(32, true);
            Human h4 = new Human(33, false);
            h2.say();
            h3.say();
            h4.say();

            Human h5 = new Human(1, 2, false);
            Human h6 = new Human(2, 3, true);
            h5.say();
            h6.say();

            Human2 h11 = new Human2();
            h11.say();
            Human2 h12 = new Human2();
            h12.say();
            h11.age = 40;
            h11.say();
        }
    }
}