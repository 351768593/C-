using System;

namespace c29
{
    class C29
    {
        public static void run()
        {
            A a = new A();
            A1 a1 = a;a1.a();

            C1 c1 = new C1();
            C2 c2 = new C2();
            
        }
    }
    interface A1 { void a(); }
    interface A2 { void a(); }
    class A : A1, A2 { void A1.a() { } void A2.a() { } }

    class C1
    {
        public int c1n1;
        public int c1n2;
        protected int c1n3;
        protected int c1n4;
        private int c1n5;
        private int c1n6;
        
        protected int getC1n5()
        {
            return c1n5;
        }
        public int getC1n6()
        {
            return c1n6;
        }

        public C1()
        {
            c1n1 = c1n2 = c1n3 = c1n4 = c1n5 = c1n6 = 0;
        }
        protected C1(int num)
        {
            c1n1 = c1n2 = c1n3 = c1n4 = c1n5 = c1n6 = num;
        }
    }
    class C2 : C1
    {
        /*
        继承关系中实例化子类的流程：
        先执行父类的构造函数，再执行子类的构造函数。

        继承关系的实例化：
        如果父类的构造函数没有空参构造函数，全是带参数的，则子类必须要写构造函数，
        构造函数的形参中必须包含父类构造函数所需要的参数，
        还要用base()把父类构造函数所需要的参数传递父类。
         */

        public C2(int num) : base(num) { }
        public C2()
        {
            c1n1 = 1;
            c1n2 = 2;
        }

        public int getSum() // C2类独有的方法
        {
            return c1n1 + c1n2;
        }
    }
    sealed class C3 // 密封类 不允许被继承
    {
        public int n1;
        protected int n2;
        private int n3;
    }
    abstract class C4
    {
        public int n1;
    }
}