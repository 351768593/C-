using System;

namespace t16
{
    class T16
    {
        
        public static void t1()
        {
            /*输出九九乘法表-左下半角形式*/
            for (int a=1;a<=9;a++)
            {
                for(int b=1;b<=a;b++)
                {
                    Console.Write(a+"*"+b+"="+(a*b)+"\t");
                }
                Console.WriteLine(); // 换行
            }

            Console.WriteLine("\n\n\n\n");

            /*输出九九乘法表-右上半角形式*/
            for (int a = 1; a <= 9; a++)
            {
                for (int c = a; c >1; c--)
                    Console.Write("\t");
                for (int b = a ; b<=9; b++)
                {
                    Console.Write(a + "×" + b + "=" + (a * b) + "\t");
                }
                Console.WriteLine(); // 换行
            }
        }

    }
}