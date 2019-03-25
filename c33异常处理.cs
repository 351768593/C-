using System;

namespace c33
{
    class C33
    {
        public static void run()
        {
            int a = 1;
            int b = 0;
            int c = a / b;
            Console.WriteLine("result : "+c);
            
        }
        public static void run2()
        {
            try
            {
                Console.WriteLine(" 1 / 0 ==");
                int a = 1;
                int b = 0;
                int c = a / b;
                
                Console.WriteLine("result : " + c);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception !");
                Console.WriteLine(e.StackTrace);
            }
        }
        public static  void run3()
        {
            try
            {
                Console.WriteLine("1");
                Console.WriteLine("2");
                throw new Exception("权限不足");
                Console.WriteLine("3");
                Console.WriteLine("4");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
        }
        
        class E1 : Exception
        {
            public E1() : base() { }
            public E1(string msg) : base(msg) { }
            public E1(string msg, Exception e):base(msg,e){ }
        }
        class E2 : Exception { }
        class E3 : Exception { }
        class E4 : Exception { }
        class E5 : Exception { }
        public static void run4()
        {
            try
            {
                int a = 123;
                switch (a)
                {
                    case 1:
                        throw new E1();
                    case 2:
                        throw new E2();
                    case 3:
                        throw new E3();
                    case 4:
                        throw new E4();
                    default:
                        throw new E5();
                }
            }
            catch (E1 e)
            {
                Console.WriteLine("e1");
            }
            catch(E2 e)
            {
                Console.WriteLine("e2");
            }
            catch(E3 e)
            {
                Console.WriteLine("e3");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception");
            }
        }

        public static void run5()
        {
            try
            {
                Console.WriteLine("line1");
                int a = 1, b = 100;
                Console.WriteLine(a/b);
                Console.WriteLine("line2");
            }
            catch(Exception e)
            {
                Console.WriteLine("exception");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }


    }
}
