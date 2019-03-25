using System;
using System.Collections;
using System.Collections.Generic;

namespace c26
{
    class C26
    {
        // https://msdn.microsoft.com/zh-cn/library/system.collections.generic(v=vs.100).aspx
        class C { public int num; }
        public static void run()
        {
            ArrayList list1 = new ArrayList(); // list1不是泛型集合
            List<C> list2 = new List<C>();
            List<int> list_int = new List<int>();

            System.Collections.Generic.LinkedList<int> linkedList = new LinkedList<int>();
            LinkedListNode<int> node = linkedList.First;
            
            // list1 不是泛型集合 可以放入任何种类的数据
            list1.Add(1);
            list1.Add("2");
            list1.Add(true);
            list1.Add('4');
            list1.Add(null);
            list1.Add(new C());
            // list2 是泛型集合 只能放入声明集合时声明的数据类型的数据
            
            list2.Add(new C());
            list2.Add(new C());
            C c = new C();
            list2.Add(c);

            // list1 不是泛型集合 取出数据的时候是object类型 需要手动显示类型转换成需要的类型
            object obj1 = list1[0]; // list1.Add(1);
            int num1 = (int)obj1;
            int num2 = (int)list1[0];
            object obj2 = list1[1]; // list1.Add("2");
            string str1 = (string)obj2;

            // list2 是泛型集合 取出的数据 是声明集合时声明的数据类型
            C c2 = list2[0];
            C c3 = list2[1];
            


            Hashtable hashtable1 = new Hashtable(); // 非泛型集合
            hashtable1.Add(1, "1");
            hashtable1.Add(true, "12344");
            hashtable1.Add('a', 123);
            
            Dictionary<String, String> hashtable2 // 泛型集合
                = new Dictionary<string, string>();
            

            Dictionary<int, C> hashtable3 // 泛型集合
                = new Dictionary<int, C>();
            
        }
    }
}