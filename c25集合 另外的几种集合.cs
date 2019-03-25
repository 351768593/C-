using System;
using System.Collections;

namespace c25
{
    class C25
    {
        public static void c1()
        {
            // https://baike.baidu.com/item/%E5%A0%86%E6%A0%88
            /*在计算机领域，堆栈是一个不容忽视的概念，堆栈是两种数据结构。
             * 堆栈都是一种数据项按序排列的数据结构，只能在一端(称为栈顶(top))对数据项进行插入和删除。
             * 在单片机应用中，堆栈是个特殊的存储区，主要功能是暂时存放数据和地址，通常用来保护断点和现场。
             * 要点：堆，队列优先,先进先出（FIFO—first in first out）。
             * 栈，先进后出(FILO—First-In/Last-Out)。*/

            // 栈
            // System.Collections.Stack // LIFO // FILO
            Stack stack1 = new Stack();
            stack1.Push("push to top");
            stack1.Peek(); // returns the object at the top of Stack without removing it
            
            stack1.Pop(); // removes and returns the object at the top of the stack
        }
        public static void t1()
        {
            // 括号匹配
            // 一个字符串里有若干大中小括号, 现在要求计算字符串里的括号是否匹配
            // ()()[]{[]}是匹配的  [({})]是匹配的
            // (]不是匹配的 {{}}}不是匹配的
        }




        public static void c2()
        {
            // https://baike.baidu.com/item/%E9%98%9F%E5%88%97/14580481
            // System.Collections.Queue
            /* 队列是一种特殊的线性表，
             * 特殊之处在于它只允许在表的前端（front）进行删除操作，
             * 而在表的后端（rear）进行插入操作，
             * 和栈一样，队列是一种操作受限制的线性表。
             * 
             * 进行插入操作的端称为队尾，进行删除操作的端称为队头。
             * 队列中没有元素时，称为空队列。
                队列的数据元素又称为队列元素。
                在队列中插入一个队列元素称为入队，
                从队列中删除一个队列元素称为出队。
                
            因为队列只允许在一端插入，在另一端删除，
            所以只有最早进入队列的元素才能最先从队列中删除，
            故队列又称为先进先出（FIFO—first in first out）线性表。*/

            Queue q1 = new Queue();
            q1.Enqueue(1); // adds an object to the end of the Queue
            q1.Enqueue(2);
            q1.Dequeue(); // removes and returns the object at the beginning of the Queue
        }
        public static void t2()
        {
            ;
        }

        public static void c3()
        {
            // https://baike.baidu.com/item/%E6%A0%91/2699484
            // 树
            /*
             * 树状图是一种数据结构，它是由n（n>=1）个有限节点组成一个具有层次关系的集合。
             * 把它叫做“树”是因为它看起来像一棵倒挂的树，也就是说它是根朝上，而叶朝下的。
             * 它具有以下的特点：
             * 每个节点有零个或多个子节点；
             * 没有父节点的节点称为根节点；
             * 每一个非根节点有且只有一个父节点；
             * 除了根节点外，每个子节点可以分为多个不相交的子树；
             */
        }
        public static void t3()
        {
            // 身份证号-个人信息的储存和搜索
            // 18位身份证号
        }
    }
}