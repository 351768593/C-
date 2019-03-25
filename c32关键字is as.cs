using System;

namespace c32
{
    class C1 { }
    class C2 : C1 { }
    class C3 : C2 { }
    class C32
    {
        public static void run2(object obj)
        {
            if(obj is object)
            {
                Console.WriteLine("参数是object类型的 ");
            }
            if(obj is int )
            {
                int num = (int)obj;
                Console.WriteLine("参数是int类型的 参数的值+1是"+(num+1));
            }
            else if (obj is string)
            {
                Console.WriteLine("参数是字符串类型的 ");
            }
            else if (obj is bool)
            {
                Console.WriteLine("参数是布尔类型的 ");
            }
        }
        public static void run()
        {
            C1 c1 = new C1();
            C2 c2 = new C2();
            C3 c3 = new C3();
            Console.WriteLine(c1 is C2);


            string str="123456abcdef";
            int num = 1;
            object obj = str;

            bool isStr1 = str is string;
            bool isStr2 = num is string;
            bool isStr3 = obj is string;

            Console.WriteLine("isStr1==" + isStr1);
            Console.WriteLine("isStr2==" + isStr2);
            Console.WriteLine("isStr3==" + isStr3);

            object obj2="";
            if(obj2 is string)
            {
                string str2 = (string)obj2;
            }
            
        }
    }
}