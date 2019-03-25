using System;

namespace c14
{
    class C14
    {
        public static void run()
        {
            
            int flag = 3;
            switch(flag)
            {
                case 1:
                    Console.WriteLine("flag等于1");
                    break;
                case 2:
                    Console.WriteLine("flag等于2");
                    break;
                case 3:
                    Console.WriteLine("flag等于3");
                    break;
                //default:
                //    Console.WriteLine("flag等于其它值 输入的值是 : "+flag);
                //    break;
            }

            switch(flag)
            {
                case 1: case 2:
                    Console.WriteLine("flag 的值等于1或者2");
                    break;
                case 3:
                    Console.WriteLine("flag 的值等于3");
                    break;
                default:
                    Console.WriteLine("flag 的值等于其它值");
                    break;
            }
        }
    }
}