using System;
using System.IO;

namespace FE
{
    class code
    {
        public static void t1()
        {
            int sum = 0;
            for(int i=200;i<=300;i++)
            {
                sum += i;
            }
            Console.WriteLine("sum==" + sum);
        }
        public static void t2()
        {
            int count = 0;
            int sum = 0;
            for(int i=30500;i<62500;i++)
            {
                if(i%3==0||i%5==0)
                {
                    count++;
                    sum += i;
                }
            }
            Console.WriteLine("sum=="+sum+" count=="+count);
        }
        public static bool pass(int i)
        {
            int i1 = i % 10;
            int i2 = i % 100 / 10;
            int i3 = i % 1000 / 100;
            int i4 = i / 1000;
            if (i1 == i4 && i2 == i3)
                return true;
            return false;
        }
        public static void t3()
        {
            int count = 0;
            for(int i=1000;i<=9999;i++)
            {
                if(pass(i))
                {
                    count++;
                }
            }
            Console.WriteLine("count=="+count);
        }
        public static void t4()
        {
            int count = 0;
            for(int a=0;a<=100;a++)
            {
                for(int b=0;b<=100;b++)
                {
                    for(int c=0;c<=100;c++)
                    {
                        if (a == b * 2 && c!=0 && b % c == 0)
                            count++;
                    }
                }
            }
            Console.WriteLine("count=="+count);
        }
        public static void t5()
        {
            int[] times = new int['z' - 'a' + 1];
            string line = Console.ReadLine();
            char[] chars = line.ToCharArray();
            foreach (char c in chars)
            {
                if((c>='a'&&c<='z')||(c>='A'&&c<='Z'))
                {
                    char c2 = char.ToLower(c);
                    times[c2 - 'a']++;
                }
            }
            int maxTimes = int.MinValue;
            for(int i=0;i<'z'-'a'+1;i++)
            {
                if (times[i] > 0)
                {
                    Console.WriteLine("Char [" + (char)('a' + i) + "] == " + times[i]);
                }
                if(times[i]>maxTimes)
                {
                    maxTimes = times[i];
                }
            }

            for(int i=0;i<'z'-'a'+1;i++)
            {
                if(times[i]==maxTimes)
                {
                    Console.WriteLine("MAX : "+(char)('a'+i)+" == "+maxTimes);
                }
            }
        }
        public static void t6()
        {
            for(int a=1;a<=18;a++)
            {
                for(int b=1;b<=18;b++)
                {
                    Console.WriteLine(a+"×"+b+" == "+(a*b));
                }
            }
        }
        public static void t7()
        {
            try
            {
                FileStream ifs = File.OpenRead("./1.txt");
                StreamReader reader = new StreamReader(ifs);

                string l1 = reader.ReadLine();
                string l2 = reader.ReadLine();

                int n1 = int.Parse(l1);
                int n2 = int.Parse(l2);

                int sum = n1 + n2;

                FileStream ofs = File.OpenWrite("./2.txt");
                StreamWriter writer = new StreamWriter(ofs);
                writer.WriteLine(sum);

                reader.Close();
                ifs.Close();
                writer.Flush();
                writer.Close();
                ofs.Flush();
                ofs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }
    }

    class C // 圆形
    {
        public double radius;
        public double A
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }
        public double getA()
        {
            return radius * radius * Math.PI;
        }
    }
    class C2 // 圆柱
    {
        public C c; // 底面
        public double h;
        public double getA()
        {
            return 2 * c.getA() + 2 * c.radius * Math.PI * h;
        }
        public double getV()
        {
            return c.getA() * h;
        }
    }

    class stack // 先进先出
    {
        private int[] datas;
        private int count;
        public stack()
        {
            datas = new int[100];
            count = 0;
        }
        public void show()
        {
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("data["+i+"]=="+datas[i]);
            }
            Console.WriteLine("count == "+count);
        }
        public void input(int data) // 输入一个数据
        {
            datas[count] = data;
            count++;
            // datas[count++]=data;
        }
        public int output() // 输出一个数据
        {
            int ret=datas[count -1];
            count--;
            return ret;
            // return data[count-- -1];
        }
        public int top()
        {
            return datas[count-1];
        }
    }
}