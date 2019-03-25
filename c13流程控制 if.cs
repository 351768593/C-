using System;

namespace c13
{
    class C13
    {
        public static void exm()
        {
            bool flag=false;

            if((bool)(5 % 2))
            {
                ;
            }

            // if 常见的形式
            if(flag)
            {
                Console.WriteLine("1-flag为真");
            }
            
            if(flag)
            {
                Console.WriteLine("2-flag为真");
            }
            else
            {
                Console.WriteLine("2-flag为假");
            }

            int flag2 = 2;
            if(flag2==0)
            {
                Console.WriteLine("flag等于0");
            }
            else if(flag2==1)
            {
                Console.WriteLine("flag等于1");
            }
            else if(flag2==2)
            {
                Console.WriteLine("flag等于2");
            }
            else
            {
                Console.WriteLine("flag等于其它值");
            }
        }

        public static void exm2()
        {
            int a = 15;
            if(a==1)
            {
                Console.WriteLine("a== 1");
            }

            if(a>1)
            {
                Console.WriteLine("a大于1");
            }
            else
            {
                Console.WriteLine("a小于等于1");
            }

            if(a>10)
            {
                Console.WriteLine("a大于10");
            }

            if(a>100)
            {
                Console.WriteLine("a大于100");
            }
        }
    }
}