using System;

namespace c17
{
    class C17_2
    {
        public static void run()
        {
            // Split(string str) 方法会把字符串按照指定内容分割成一维数组
            string str1 = "123_456_789_012";
            string[] strs = str1.Split("_");
            Console.WriteLine("字符串1 分割出 "+strs.Length+" 个子字符串");
            Console.WriteLine("分割后内容 :");
            for (int i=0;i<strs.Length;i++)
            {
                Console.WriteLine(strs[i].Length + "|" + strs[i] + "|");
            }

            string str2 = "123_A_456_B_A_789_A_12345";
            string[] strs2 = str2.Split("A_");
            Console.WriteLine("字符串2 分割出 " + strs2.Length + " 个子字符串");
            Console.WriteLine("分割后内容 :");
            foreach (string str in strs2)
            {
                Console.WriteLine(str.Length + "|" + str + "|");
            }

            string str3 = "123456789";
            string[] strs3 = str3.Split("abc");
            Console.WriteLine("字符串3 分割出 " + strs3.Length + " 个子字符串");
            Console.WriteLine("分割后内容 :");
            foreach (string str in strs3)
            {
                Console.WriteLine(str.Length+"|"+str + "|");
            }

            string str4 = "123456789";
            string[] strs4 = str3.Split("123456789");
            Console.WriteLine("字符串3 分割出 " + strs4.Length + " 个子字符串");
            Console.WriteLine("分割后内容 :");
            foreach (string str in strs4)
            {
                Console.WriteLine(str.Length + "|" + str + "|");
            }
        }
    }
}