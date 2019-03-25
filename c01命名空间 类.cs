using System; // 使用一个命名空间



namespace c1 // 声明一个命名空间
{
    // 在命名空间中声明不同的类
    class C1 // 声明类名
    { // 类体 用大括号括起来
        public int a; // 为类声明成员变量
        public int b;
        public static int c; // 一个静态成员变量

        public void print()
        {
            Console.WriteLine("hello world! ");
        }
        public int sum() // 为类声明成员方法
        {
            return a + b;
        }

        /*
        public、int之类的单词是 关键字
        a、b、sum之类的单词是 变量/方法名 可以自己随便起


        public int a; 意思是给C1声明了一个类型为int、名字为a的非静态成员变量
        非静态成员变量能在这个类的所有对象的所有方法里直接调用
        静态成员变量会在后续提到

        public int sum()和下面大括号的内容 意思是给C1声明了一个返回类型为int、名字为sum的方法
        大括号里的内容（代码）是方法体 方法体是去完成一些操作
        比如 上面的print方法就是向控制台输出一行 hello world
        */
    }

    class Dog // 狗 类
    {
        public int age; // 年龄
        public float weight; // 重量
        public static int eyes;
        public int legs;
        public static void bark() // 叫
        {
            Console.WriteLine("dog wang!");
        }
        public void run() // 跑
        {
            Console.WriteLine("dog run!");
        }
        public void eat() // 吃
        {
            Console.WriteLine("dog eat!");
        }
        public void say()
        {
            Console.WriteLine("这条狗"+age+"岁");
        }
    }


    class C1_2
    {
        public static void run()
        {
            Console.WriteLine("c1_2.run");
        }
    }
    class C1_3
    {
        public static void run()
        {
            Console.WriteLine("c1_3.run");
        }
    }


    namespace n1 // 在命名空间里嵌套命名空间
    {
        class C1_n1_1
        {
            public static void run()
            {
                Console.WriteLine("c1_n1_1.run");

                int a;
                int A;
                int abc;
                int Abc;
                int _a;
                int a1;
                int a2;
                int a_1;
                int a_2;
            }
        }
    }

    namespace n2
    {
        class C1_n2_1
        {
            public static void run()
            {
                Console.WriteLine("c1_n2_1.run");
            }
        }
    }
}