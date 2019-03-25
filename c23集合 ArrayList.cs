using System;
using System.Collections;

namespace c23
{
    class C23
    {
        public static void p(ArrayList list)
        {
            foreach(object obj in list)
            {
                Console.Write(obj+"\t\t");
            }
            Console.WriteLine("\n\n");
        }

        public static void run()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add("something 1");
            list.Add("something 2");
            list.Add("something 3");

            Console.WriteLine("第一个元素 : " + list[1]);
            int num = (int)list[1]; // 类型转换
            Console.WriteLine("第一个元素 : " + num);

            Console.WriteLine("第三个元素 : "+ list[3]);
            

            Console.WriteLine("表长度 "+ list.Count);

            p(list);
            Console.WriteLine("插入内容");
            
            list.Insert(1,"insert1"); // 插入内容
            p(list);

            Console.WriteLine("表长度 " + list.Count);


            Console.WriteLine("是否包含 2 数字 : " + list.Contains(2));
            Console.WriteLine("是否包含 2 字符串 : " + list.Contains("2"));
            Console.WriteLine("是否包含 abc : " + list.Contains("abc"));

            Console.WriteLine("字符串2的位置是 "+ list.IndexOf("2"));
            Console.WriteLine("数字2的位置是 " + list.IndexOf(1));

            Console.WriteLine("删除字符串2 : ");
            list.Remove("2");
            p(list);

            Console.WriteLine("删除数字2 : ");
            list.Remove(2);
            p(list);

            Console.WriteLine("删除第2个元素 : ");
            list.RemoveAt(2);
            p(list);

            Console.WriteLine("清空表 : ");
            list.Clear(); // 清空表
            p(list);
            
            
        }
    }
}