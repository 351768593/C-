using System;

namespace c16
{
    class C16
    {
        public static void run()
        {
            
        }
        public static void exm1()
        {
            int i = 0;
            while(i<10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public static void exm1_2()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void exm2()
        {
            int i = 0;
            int sum = 0;
            while(i<=100)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("sum=="+sum);
        }
        public static void exm2_2()
        {
            int sum = 0;
            for(int i=0;i<=100;i++)
            {
                sum += i;
            }
            Console.WriteLine("sum=="+sum);
        }
    }
}