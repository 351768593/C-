// 命名空间和类的别名
// using [别名] = [限定名|命名空间名];
using System;

using c1n1 = c1.n1;
using c1n11 = c1.n1.C1_n1_1;

namespace c1
{
    //class C1 {}


    class c1_3
    {
        c1n11 c; // 直接使用别名
    }
}

/*
练习
声明多个不同的命名空间
声明几个不同的类 为类定义几个不同的方法
然后在Main方法里调用这些方法
*/