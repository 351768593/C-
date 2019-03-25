using System;

namespace c7
{
    class C7
    {
        public static void run()
        {
            // 表达式由操作数和运算符组成
            int a = 1;
            int b = 2;

            int c = a + b; // c==3

            a = a + 1; // a==2
            a++; // a +=1; // a = a + 1;
            a--; // a -=1;

            ++a;

            b = b + 2; // b==4
            int d = a + b - 1; // 5
            int e = (1 * 2 + 3) * 4;
            

            // 运算符
            /*
                算术运算符
                +
                -
                *
                /
                %
                !

                // 赋值运算符
                =
                +=
                -=
                *=
                /=
                %=

                &=
                |=
                >>=
                <<=
                ^=

                关系运算符
                ==
                >
                >=
                <
                <=
                !=

                逻辑运算符
                &
                |
                ^

                移位运算符
                >>
                <<
                

                特殊运算符
                is
                as
                ?:
                new
                typeof
            */
        }
    }
}