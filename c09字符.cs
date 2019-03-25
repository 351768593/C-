using System;

namespace c9
{
    class C9
    {
        public static void run()
        {
            char c1 = 'A';
            char c2 = 'a';
            char c3 = '我';
            char c4 = '+';
            Console.WriteLine("c1 : " + c1);
            Console.WriteLine("c2 : " + c2);
            Console.WriteLine("c3 : " + c3);
            Console.WriteLine("c4 : " + c4);

            int i1 = c1; // 因为字符型储存的是字符的Unicode编码 这个编码是16位的
            int i2 = c2; // 所以字符型可以方便的直接转换为int型或long型变量
            short i3 = (short)c1;
            byte i4 = (byte)c1; // 其它整型就不行了 // 注意这里可能会溢出
            Console.WriteLine("i1 : " + i1);
            Console.WriteLine("i2 : " + i2);
            Console.WriteLine("i3 : " + i3);
            Console.WriteLine("i4 : " + i4);

            char c5 = (char)i1; // 从int型转char型也不能直接转换
            Console.WriteLine("c5 : "+c5);

            // 字符型相减
            Console.WriteLine("A : "+(int)'A'+" , B : "+(int)'B');
            Console.WriteLine("a : " + (int)'a' + " , b : " + (int)'b');
            int i11 = 'A' + 'B'; // 字符型变量相加减返回的是
            int i12 = 'A' - 'B'; // 这两个字符的Unicode编码值相加减的结果
            // char b = 'A' - 'B';
            Console.WriteLine("a11 : " + i11);
            Console.WriteLine("a12 : " + i12);


            // 字符型的一些接口

            /*
            IsDigit(Char)	
指示指定的 Unicode 字符是否属于十进制数字类别。

            IsLetter(Char)	
指示指定的 Unicode 字符是否属于 Unicode 字母类别。

            IsLetterOrDigit(Char)	
指示指定的 Unicode 字符是否属于字母或十进制数字类别。

            IsLower(Char)	
指示指定的 Unicode 字符是否属于小写字母类别。

            IsNumber(Char)	
指示指定的 Unicode 字符是否属于数字类别。

            IsPunctuation(Char)	
指示指定的 Unicode 字符是否属于标点符号类别。


            IsSeparator(Char)	
指示指定的 Unicode 字符是否属于分隔符类别。

            IsSymbol(Char)	
指示指定的 Unicode 字符是否属于符号字符类别。

            IsUpper(Char)	
指示指定的 Unicode 字符是否属于大写字母类别。

            IsWhiteSpace(Char)	
指示指定的 Unicode 字符是否属于空格类别。

            ToLower(Char)	
将 Unicode 字符的值转换为它的小写等效项。

            ToUpper(Char)	
将 Unicode 字符的值转换为它的大写等效项。
*/
            bool i21 = char.IsLetter('A');
            bool i22 = char.IsLetter('1');

            bool i23 = char.IsLower('A');
            bool i24 = char.IsLower('a');
            bool i25 = char.IsLower('1');

            bool i26 = char.IsPunctuation('.');

            char i27 = char.ToLower('A');
            char i28 = char.ToUpper('a');


            char a1 = 'a';
            // 1 + 2 * 3
            int a2 = sum(1+2, 2) * 3;
            int a3 = sum(100, 200);
            int a4 = sum('A'+'B',100);
            Console.WriteLine("a2=="+a2);
            Console.WriteLine("a3==" + a3);
            Console.WriteLine("a4==" + a4);

            bool isNum = char.IsNumber('A');
            Console.WriteLine("'A' 是数字? : "+isNum);


            Console.WriteLine("i21 : "+i21+" , i22 : "+i22
                +" ,\n i23 : "+i23+" , i25 : "+i25
                +" ,\n i26 : "+i26
                +" ,\n i27 : "+i27+" , i28 : "+i28);
        }

        public static int sum(int a,int b)
        {
            return a + b;
        }

    }
}