using System;

namespace c20
{
    class C20
    {
        class C
        {
            public int num;
        }
        public static void sum(int a,int b)
        {
            int sum = 0;
            for(int i=a;i<b;i++)
            {
                sum += a;
            }
            Console.WriteLine("从a加到b等于"+sum);
        }
        public static void run()
        {
            // 值类型
            int n1 = 1;
            Console.WriteLine(n1);
            int n2 = 2;
            Console.WriteLine(n2);
            int n3 = 3;
            Console.WriteLine(n3);
            int n4 = 4;
            Console.WriteLine(n4);
            // 引用型
            C c1;
            C c2 = new C();
            C c3 = new C();
            c2.num = 1232;
            c1 = new C();
            Console.WriteLine(c1.num);
            c3.num = 1233;
            c1.num = 1231;
            Console.WriteLine(c1.num);
            // 过程
            C[] cs = new C[10];
            for(int i=0;i<cs.Length;i++)
            {
                cs[i] = new C();
                cs[i].num = 1230 + i;
                Console.WriteLine("cs["+i+"].num=="+cs[i].num);
            }

            // 方法
            sum(1, 5);

            sum(3, 6);
        }
    }
    
}