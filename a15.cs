using System;
using System.Threading;

namespace a15
{
    class A15
    {
        public static void e1()
        {
            while(true)
            {
                Console.WriteLine(DateTime.Now.Second);
                Thread.Sleep(2000);
            }
        }
        public static void e2()
        {
            int sum = 0;
            while(true)
            {
                string line = Console.ReadLine();
                bool isNum = int.TryParse(line, out int num);
                if(isNum)
                {
                    if (num == 0)
                    {
                        break;
                    }
                    else
                    {
                        sum += num;
                    }
                }
            }
            Console.WriteLine("所有数字的和是: "+sum);
        }

        public static void t1()
        {
            // 使用循环输出1到30内的所有的整数 (while)
            int i = 0;
            while(i<30)
            {
                i++;
                Console.WriteLine(i);
            }
        }

        public static void t2()
        {
            /*
             2. 使用循环输出所有英文字母的大小写 (while)
            char.ToUpper(char c)
            char.ToLower(char c)*/
            char c = (char)('a' - 1);
            while(c<'z')
            {
                c++;
                Console.WriteLine(" "+c+","+char.ToUpper(c) );
            }
            Console.WriteLine("for写法: ");
            for(char c2='a';c2<='z';c2++)
            {
                Console.WriteLine(" " + c2 + "," + char.ToUpper(c2));
            }
        }

        public static void t3()
        {
            // 3. 求从1到1000的和并输出 (while)
            int i = 0;
            int sum = 0;
            while(i<1000)
            {
                i++;
                sum += i;
            }
            Console.WriteLine("sum == "+sum);
        }

        public static void t4()
        {
            /*
             4. 输入一个数字n, 求从2开始的n个偶数和 (while)
            比如输入数字3, 输出12 (2+4+6); 输入数字5, 输出30 (2+4+6+8+10)*/
            int sum = 0;
            int i = 2;
            string line = Console.ReadLine();
            bool isNum = int.TryParse(line, out int n);
            if(isNum && n>0)
            {
                int j = 1;
                while(j<=n) // i<=n*2
                {
                    sum += i;
                    i += 2;
                    j++;
                }
                Console.WriteLine("sum=="+sum);
            }
        }

        public static void t5()
        {/*5. 循环输入一些数字, 以0结束输入 (while if)
        输出这些数字的和、平均数、最大数、最小数、奇数的个数、偶数的个数
        int.MaxValue int型最大值
        int.MinValue int型最小值*/
            ;
            int sum = 0;
            int countNum = 0;
            int countOdd = 0; // 奇数
            int countEven = 0; // 偶数
            int min = int.MaxValue;
            int max = int.MinValue;
            while (true)
            {
                string line = Console.ReadLine();
                bool isNum = int.TryParse(line, out int num);
                if (isNum)
                {
                    if (num == 0)
                    {
                        break;
                    }
                    else
                    {
                        sum += num;
                        countNum++;
                        if (num % 2 == 0)
                        {
                            countEven++;
                        }
                        else
                        {
                            countOdd++;
                        }

                        if (num > max)
                        {
                            max = num;
                        }
                        if (num < min)
                        {
                            min = num;
                        }
                    }
                }
            }

            Console.WriteLine("和:" + sum + " 平均数" + (sum / (float)countNum) + " 奇数:"
                + countOdd + " 偶数:" + countEven 
                + "最大数: "+max+" 最小数"+min);
        }

        public static void t6()
        {
            /*6. 循环接收3行输入: (while if switch)
            第一行: 数字1
            第二行: 运算符 (+ - * / %)
            第三行: 数字2
            每次输出数字1和数字2按照运算符运算的结果
            (如果0作为除数则输出错误, 如果输入的两个数都是0则退出循环)
                bool int.TryParse(string str,out int num)
            */
            while(true)
            {
                string line1 = Console.ReadLine();
                string line2 = Console.ReadLine();
                string line3 = Console.ReadLine();
                bool isNum1 = float.TryParse(line1, out float num1);
                bool isNum2 = float.TryParse(line3, out float num2);
                if(isNum1 && isNum2)
                {
                    if (num1 == 0 && num2 == 0)
                        break;

                    float result = 0;
                    switch(line2)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if(num2==0)
                            {
                                Console.WriteLine("0不能为除数");
                            }
                            else
                            {
                                result = num1 / num2;
                            }
                            break;
                        default:
                            Console.WriteLine("输入的内容是 : " +line2+" 不是运算符");
                            break;
                    }
                    if(line2!="/" && num2!=0)
                        Console.WriteLine("result : "+result);
                }
            }
        }

        public static void t7()
        {
            /*
            7. 求水仙花数的个数 (while if)
            水仙花数: 一个3位数, 它的每个位上的数字的 3次幂之和等于它本身
            例如：1^3 + 5^3+ 3^3 = 153
             */
            int num = 100;
            int sum = 0;
            while(num<=999)
            {
                if (pass(num))
                {
                    Console.WriteLine(num);
                    sum++;
                }
                num++;
            }
            Console.WriteLine("水仙花数有"+sum+"个");
        }
        public static bool pass(int num)
        {
            int num1 = num % 10;
            int num2 = num % 100 / 10;
            int num3 = num / 100;

            return num1 * num1 * num1
                + num2 * num2 * num2
                + num3 * num3 * num3
                == num;
        }

        public static void t8()
        {
            /*
             8. 求从1到1000里所有能整除3的数的和
             减去
             所有能整除5或能整除6的数的和 (while if)*/
            int i = 1;
            int sum1 = 0;
            int sum2 = 0;
            while(i<=1000)
            {
                if(i%3==0)
                {
                    sum1 += i;
                }
                if(i%5==0||i%6==0)
                {
                    sum2 += i;
                }
                i++;
            }
            Console.WriteLine("result : "+(sum1-sum2));
        }

        public static void t9()
        {
            /*
             * 9. 循环接收输入年份, 判断这个年份是不是闰年 (while if)
                能被4整除但不能被100整除的年份为普通闰年
                能被400整除的为世纪闰年
             */
             while(true)
            {
                string line = Console.ReadLine();
                bool isNum = int.TryParse(line, out int num);
                if(isNum)
                {
                    Console.WriteLine("输入的数字是 : " + num
                        +" , 这个数字"+(isPass(num)?"是":"不是")+"闰年");
                }
            }
             for(; true; )
            {
                ;
            }
        }
        public static bool isPass(int num)
        {
            if ((num % 4 == 0 && num % 100 != 0) || num % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void t10()
        {
            /*
             * 10. 求从公元1年到公元1000年里, 共有多少闰年并输出 (while if)
             */
            int i = 1;
            int sum = 0;
            while(i<=1000)
            {
                if(isPass(i))
                {
                    sum++;
                }
                i++;
            }
            Console.WriteLine("从公元1年到公元1000年里, 共有"+sum+"闰年");
        }

        public static void t11()
        {
            /*
             * 11. 输入一个数字, 判断这个数是不是素数 (while if)
            质数（prime number）又称素数
            质数定义为在大于1的自然数中, 除了1和它本身以外不再有其他因数
            比如3=1*3, 因数只有有1和3, 所以3是质数
            4=1*4=2*2, 因数有1、2和4, 所以4不是质数
            规定1不是素数
             */
            string line = Console.ReadLine();
            bool isNum = int.TryParse(line, out int num);
            if(isNum)
            {
                Console.WriteLine( num+(isPrime(num)?"是":"不是")+"素数");
            }
        }
        public static bool isPrime(int num)
        {
            if (num <= 1)
                return false;
            int i = 2;
            while(i<num)
            {
                if(num%i==0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        public static void t12()
        {
            /*
             * 12. 输入一个数字,
             * 如果这个数字不是素数, 
             * 输出这个数字所有的因数 (while if)
             */
            string line = Console.ReadLine();
            bool isNum = int.TryParse(line, out int num);
            if (isNum)
            {
                bool isP = isPrime(num);
                Console.WriteLine(num + (isP ? "是" : "不是") + "素数");

                if(!isP)
                {
                    int i = 1;
                    while(i<num/2)
                    {
                        if(num%i==0)
                        {
                            Console.WriteLine(i+", "+(num/i));
                        }
                        i++;
                    }
                }
            }
        }
    }
}