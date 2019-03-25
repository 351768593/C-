using System;

namespace c27
{
    class C27
    {
        public static void run()
        {
            C c1 = new C();
        }
    }

    class C
    {
        public int n1; // 所有地方都能访问
        protected int n2; // 只有当前类和子类能访问
        private int n3; // 只有当前类能访问
        // public > protected > private 
        public void run()
        {
            n3 = 1;
        }
        private void run2()
        {
            ;
        }
    }
    
}