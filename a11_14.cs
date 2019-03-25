using System;

namespace a11_14
{
    class a
    {
        public static void run()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);

            switch(num)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("输入的数字不在1到7之间");
                    break;
            }
        }


        public static void t1()
        {
            //输入一个数字, 判断是奇数还是偶数
            string line = Console.ReadLine().Trim();
            bool isNum = int.TryParse(line, out int num);
            if(isNum)
            {
                Console.WriteLine("输入的是一个数字");
                if(num%2==0)
                {
                    Console.WriteLine("输入的数字是偶数");
                }
                else
                {
                    Console.WriteLine("输入的数字是奇数");
                }
            }
            else
            {
                Console.WriteLine("输入的内容不是数字");
            }
        }
        public static void t2()
        {
            string line = Console.ReadLine();
            bool isNum = int.TryParse(line, out int num);
            if (isNum)
            {
                Console.WriteLine("输入的是一个数字");
                if( (num%4==0 && num%100!=0) || num%400==0)
                {
                    Console.WriteLine("输入的数字是闰年");
                }
                else
                {
                    Console.WriteLine("输入的数字不是闰年");
                }
            }
            else
            {
                Console.WriteLine("输入的内容不是数字");
            }
        }
        public static void t3()
        {
            /*
             3. 输入一个五位数, 输出是不是回文数
               回文数: 前后对称的数字
                比如12321、121是回文数, 123不是回文数*/
            string line = Console.ReadLine().Trim();
            bool isNum = int.TryParse(line, out int num);
            if(line.Length==5) // if(num>=10000 && num<=99999)
            {
                Console.WriteLine("输入的数字是五位数");
                int n1 = num % 10; // 12345 % 10 == 5
                int n2 = num % 100 / 10; // 12345 % 100 ==45 , 45 /10 ==4
                int n4 = num % 10000 / 1000; // 12345 % 10000 ==2345,2345 / 1000 == 2
                int n5 = num / 10000; // 12345/10000==1
                Console.WriteLine("n1=="+n1+ " ,n2=="+n2+" , n4=="+n4+" , n5=="+n5 );
                if(n1==n5 && n2==n4) // 判断是否相等
                {
                    Console.WriteLine("输入的数字是回文数");
                }
                else
                {
                    Console.WriteLine("输入的数字不是回文数");
                }
            }
            else
            {
                Console.WriteLine("输入的数字不是五位数");
            }
        }
    }
}