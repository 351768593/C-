using System;

namespace c9
{
    class C9_2 // 转义字符的使用
    {
        public static void run()
        {
            string str = "这是一个\n字符串";Console.WriteLine(str);

            char c1 = '\'';
            string str2 = "'''''''''''"; Console.WriteLine(str2);
            /*
             * 编程的时候 有些字符不能直接写到代码里
             * 比如回车 或者单双引号
             * 这时就需要用到转义字符
                \n      换行(LF) ，将当前位置移到下一行开头
                \r      回车(CR) ，将当前位置移到本行开头
                \t      水平制表(HT) （跳到下一个TAB位置）
                \'      代表一个单引号（撇号）字符
                \"      代表一个双引号字符
                \0      空字符(NULL)
            */
            Console.WriteLine("这里输出一个转义双引号 : _\"_ ");
            Console.WriteLine("这里输出一个转义单引号 : _\'_ ");
            Console.WriteLine("这里输出一个转义空字符 : _\0_ ");
            Console.WriteLine("这里输出一个转义制表符 : _\t_");
            Console.WriteLine("这里有一个换行:\n这里是新一行的内容");
            Console.WriteLine("这里有一个回车:\r123");
            
            Console.WriteLine("123我\n\t\t\t他你abc".Length);


            //Console.WriteLine("i21 : " + i21 + " , i22 : " + i22
            //    + " ,\n i23 : " + i23 + " , i25 : " + i25
            //    + " ,\n i26 : " + i26
            //    + " ,\n i27 : " + i27 + " , i28 : " + i28);
        }

    }
}