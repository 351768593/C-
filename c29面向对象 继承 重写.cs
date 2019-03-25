using System;

namespace c29_2
{
    class C1
    {
        public virtual void fun()
        {
            Console.WriteLine("C1.fun virtual");
        }
        public virtual void fun2()
        {
            Console.WriteLine("C1.fun2 virtual");
        }
        public void fun3()
        {
            Console.WriteLine("C1.fun3");
        }
        public virtual void fun4()
        {
            Console.WriteLine("C1.fun4 virtual");
        }
        public virtual void fun5()
        {
            Console.WriteLine("C1.fun5 virtual");
        }
    }
    class C11 : C1
    {
        public void fun()
        {
            Console.WriteLine("C11.fun");
        }
        public new void fun2()
        {
            Console.WriteLine("C11.fun2 new");
        }
        public new void fun3()
        {
            Console.WriteLine("C11.fun3 new");
        }
        public override void fun4()
        {
            Console.WriteLine("C11.fun4 override");
        }
        public new void fun5()
        {
            Console.WriteLine("C11.fun5 new");
        }
    }
    class C29_2
    {
        public static void run()
        {
            Console.WriteLine("c1 : ");
            C1 c1 = new C1();
            c1.fun();c1.fun2();c1.fun3();c1.fun4();c1.fun5();
            Console.WriteLine("有virtual的方法允许被override \n\n");

            Console.WriteLine("c11 : ");
            C11 c11 = new C11();
            c11.fun();c11.fun2();c11.fun3();c11.fun4();c11.fun5();
            Console.WriteLine("");

            Console.WriteLine("c11 in c1 : ");
            C1 c1_2 = new C11();
            c1_2.fun();c1_2.fun2();c1_2.fun3();c1_2.fun4();c1_2.fun5();
            Console.WriteLine("new的方法相当于全新的方法, 只有使用本来类型的引用才能调用 \n\n");
            Console.WriteLine("有override的方法优先级最高 \n\n");

            Console.WriteLine("c11 in c1 to c11 : ");
            C11 c1_3 = (C11)c1_2;
            c1_3.fun();c1_3.fun2();c1_3.fun3();c1_3.fun4();c1_3.fun5();
        }
    }

    class C2
    {
        public void fun()
        {
            Console.WriteLine("C2.fun");
        }
    }

}