using System;

namespace c8
{
    class C8
    {
        public static void run()
        {
            ;
        }
        /*
        方法定义了一个流程
        定义了具体完成某项任务所需要执行的步骤
        */
        public void sayHello() // 一个名为sayHello的方法 定义了要向控制台输出一行文字Hello World
        {
            Console.WriteLine("Hello World!");
        }
        



        /*
        一个方法由如下几部分构成:
            方法名
            参数列表
            返回值
            修饰符
        */
        // public和static为方法修饰符
        // int为返回值类型 定义这个方法(流程)返回一个类型为int的值
        // sum为定义的方法名字 可以任意起
        public static int sum(int a,int b) // int a,int b定义了这个方法需要输入两个int值作为参数
        {
            int ret = a + b; // 方法体 具体进行各种操作

            return ret; // 返回语句 可以返回常量或变量 // 要求必须跟之前定义的返回值类型相同
        } // 这个方法定义了如何求两个int值的和的流程

        public static double sum(double a, double b, double c)
        {
            return a + b + c;
        }

        public static void sayHello2(int a)
            // void 型是一种特殊的返回类型
            // 定义了这个方法没有返回值
            // 比如像下面的方法 只是向控制台输出一个参数
            // 这个过程不需要返回值 就定义为void型方法
        {
            Console.WriteLine("传进来的参数是 : "+a);
        }

        public static void runSum()
        {
            // 调用静态方法是用[类名].[方法名]
            Console.WriteLine("Hello World!");
                // 这里Console其实就是一个类的名字
                // WriteLine是这个类的一个静态成员方法


            // 调用非静态方法是用[对象名].[方法名]
            c1.Dog dog = new c1.Dog();
            dog.eat();
                // 这里dog是一个对象的名字 这个对象的类型是c1.Dog
                // eat是这个对象的一个实例方法
        }
    }
}