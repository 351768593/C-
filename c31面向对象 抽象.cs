using System;

namespace c31
{
    abstract class absC1
    {
        abstract public void f1();
        abstract protected void f2();
        // abstract private void f3();
        public void f4()
        {
            Console.WriteLine("f4");
        }
    }
    class C2:absC1
    {
        // 非抽象子类 必须实现所有抽象基类里定义的抽象成员
        public override void f1()
        {
            Console.WriteLine("f1");
        }
        protected override void f2()
        {
            Console.WriteLine("f2");
        }
    }
    abstract class absC2 :absC1
    {
        // 抽象子类 可以只实现一部分 或者完全不实现 抽象基类里的成员
        // 没有实现任何方法
        public override void f1()
        {
            Console.WriteLine("f1");
        }
    }

    class C31
    {
        public static void run()
        {
            ;
        }
    }
}