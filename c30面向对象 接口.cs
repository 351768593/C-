using System;

namespace c30
{
    interface ISomething
    {
        void doSomething();
        int Num
        {
            get;
            set;
        }
        
    }
    interface ISomething2
    {
        void doSomething2();
    }
    class ClassSomething : ISomething,ISomething2
    {
        public int Num
        {
            get;
            set;
        }
        public void doSomething()
        {
            Console.WriteLine("do something");
        }
        public void doSomething2()
        {
            Console.WriteLine("do something2");
        }
    }
    class C30
    {
        public static void run()
        {
            ClassSomething some = new ClassSomething();
            some.doSomething();
            some.Num = 123;

            ISomething some1 = (ISomething)some;
            some1.doSomething();
            some1.Num = 456;

            ISomething2 some2 = (ISomething2)some;
            some2.doSomething2();
        }
    }


}