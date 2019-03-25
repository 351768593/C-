using System;
using System.Collections;

namespace c24
{
    class C24
    {
        public static void run()
        {
            Hashtable table = new Hashtable();
            
            table.Add("key1", "value1"); // 添加内容
            table.Add("key2", "value2");
            table.Add("key3", 3);
            table.Add(1, "value4");
            table.Add(5, "value5");
            table.Remove(5);
            table.Add(5, "value6");

            Console.WriteLine(table["key1"]);
            Console.WriteLine(table["key2"]);
            Console.WriteLine(table["key3"]);

            Console.WriteLine(table["key4"]==null);


            Console.WriteLine("包含 key1 : "+ table.Contains("key1"));
            Console.WriteLine("包含 key1 : " + table.ContainsKey("key1"));
            Console.WriteLine("包含 value2 : " + table.ContainsValue("value2"));


            Console.WriteLine("遍历键");
            foreach(object key in table.Keys)
            {
                Console.WriteLine(key+"  == " +table[key]);
            }


            Console.WriteLine("遍历值");
            foreach (object value in table.Values)
            {
                Console.WriteLine(value);
            }

            
            table.Remove("key1"); // 根据键删除内容
            Console.WriteLine("删除key1键值对");
            foreach (object key in table.Keys)
            {
                Console.WriteLine(key + "  == " + table[key]);
            }

            table.Clear(); // 清空表
        }
    }
}