using System;

namespace c15
{
    class C15
    {
        public static void exm()
        {
            bool flag = true;
            // while 的使用
            while(true)
            {
                ;
                Console.WriteLine(DateTime.Now.ToLocalTime()); // 输出时间
                Console.ReadLine(); // 用来暂停
            }
            
            while(flag)
            {
                ;
                if(flag)
                {
                    ;
                    break;
                }
            }

            while(flag)
            {
                ;
                if(flag)
                {
                    ;
                    continue;
                }
            }
        }

        public static void exm2()
        {
            int i = 0;
            while(i<10)
            {
                Console.WriteLine("i的值为"+i);
                i++;
            }
        }
        public static void exm3()
        {
            int i = 0;
            while(true)
            {
                Console.WriteLine("i的值为" + i);
                if (i>=15)
                {
                    break;
                }
                i += 2;
            }
        }
        public static void exm4()
        {
            int i = 0;
            while (true)
            {
                i++;
                if(i%2==0)
                {
                    continue;
                }
                Console.WriteLine("i的值为" + i);
                if (i >= 10)
                {
                    break;
                }
            }
        }
        public static void exm5()
        {
            bool flag = true;
            do
            {
                ;
            } while (flag);
        }
    }
}