using System;

namespace c10
{
    class C10
    {
        public static void run()
        {
            string str1 = "这是一个字符串";
            string str2 = "字符串由双引号括起来";
            Console.WriteLine(str1);
            Console.WriteLine(str2);


            string str = "abc12345_ABC123"; Console.WriteLine("str : " + str);
            /*
            字符串的常用接口
            */
            // Length (属性) // 字符串长度
            Console.WriteLine("str.Length : "+str.Length);
            // 取字符串中的某个字符 
            Console.WriteLine("str[2] : "+str[2]);

            // StartsWith // 是否由指定内容开始
            bool i11 = str.StartsWith("abc1");      Console.WriteLine("i11 : " + i11);
            // EndsWith // 是否由指定内容结束
            bool i12 = str.EndsWith("abc");         Console.WriteLine("i12 : " + i12);
            // Contains // 是否包含指定内容
            bool i13 = str.Contains("1234");        Console.WriteLine("i13 : " + i13);
            // IndexOf // 指定内容在字符串中的位置 从前向后找
            int i14=str.IndexOf("123");             Console.WriteLine("i14 : " + i14);
            int i15 = str.IndexOf("321");           Console.WriteLine("i15 : " + i15);
            // IndexOf // 指定内容在字符串中的位置 从后向前找
            int i16 = str.LastIndexOf("123");       Console.WriteLine("i16 : " + i16);
            int i17 = str.LastIndexOf("321");       Console.WriteLine("i17 : " + i17);


            // Insert // 插入内容
            string str11 = str.Insert(2, "STR");    Console.WriteLine("str11 : " + str11);
            // Substring // 裁剪字符串
            string str12=str.Substring(1);  /* 裁剪从位置1开始向后的所有内容*/ Console.WriteLine("str12 : " + str12);
            string str13 = str.Substring(1, 5); /* 从位置1开始 长度3的内容*/ Console.WriteLine("str13 : " + str13);
            // Replace // 替换内容
            
            string str14=str.Replace("123", "!!!"); /* 把所有的123替换成!!!*/ Console.WriteLine("str14 : " + str14);
            // Remove // 移除指定长度的内容
            string str15 = str.Remove(1); /* 移除位置1向后所有内容*/ Console.WriteLine("str15 : " + str15);
            string str16 = str.Remove(1, 3); /* 移除位置1向后 长度3的内容*/ Console.WriteLine("str16 : " + str16);

            // ToLower // 小写化
            string str17 = str.ToLower();   Console.WriteLine("str17 : " + str17);
            // ToUpper // 大写化
            string str18 = str.ToUpper();   Console.WriteLine("str18 : " + str18);

            // Trim TrimStart TrimEnd // 去掉占位用转义字符
            string str19 = "      这个字符串前后有很多空格       ".Trim();      Console.WriteLine("str19 : |" + str19+"|");
            string str20 = "      这个字符串前后有很多空格       ".TrimStart(); Console.WriteLine("str20 : |" + str20 + "|");
            string str21 = "      这个字符串前后有很多空格       ".TrimEnd();   Console.WriteLine("str21 : |" + str21 + "|");


            // Split // 分割字符串 //  以后再讲
            str.Split("_");
        }
    }
}