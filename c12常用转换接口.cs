using System;

namespace c12
{
    class C12
    {
        public static void run1()
        {
            // Parse(string number)
            // string line=Console.ReadLine();
            
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int n1 = int.Parse(str1);
            int n2 = int.Parse(str2);
            
            
            Console.WriteLine("输入的内容是 : "+str1+" , "+str2);
            Console.WriteLine("输入的数字是 : " + n1 + " , " + n2);
            Console.WriteLine("输入的内容和 : " + (str1  + str2) );
            Console.WriteLine("输入的数字和 : " + (n1+n2));
        }
        public static void run2()
        {
            // Try(string number,out int result)
            string line = Console.ReadLine();
            bool isNum = int.TryParse(line, out int num);

            Console.WriteLine(isNum ? "输入的数字是 : "+num:"输入的不是数字");
        }
        public static void run3()
        {
            ;
        }
    }
}