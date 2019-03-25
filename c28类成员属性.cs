namespace c28
{
    class C28
    {
        public static void run()
        {
            C3 c3 = new C3();
            int n = c3.Num;
        }
    }

    class C1
    {
        public int n;
        private int num; // 类的成员变量
        public int getNum() // 类的成员方法 // getter
        {
            return num;
        }
        private void setNum(int numIn) // 类的成员方法 // setter
        {
            num = numIn;
        }
    }
    class C2
    {
        private int num; // 类的成员变量
        public int Num // 类的成员属性
        {
            get
            {
                return num;
            }
            private set
            {
                num = value;
            }
        }
        public int getNum() { return num; }
        private void setNum(int value) { num = value; }
    }
    class C3
    {
        public int Num // 类的成员属性
        {
            get;
            private set;
        }
        public int Num2
        {
            set;
            private get;
        }
        public int Num3
        {
            get;
            set;
        }
        public int Num4
        {
            get;
        }
        public int Num5
        {
            set
            {
                Num3 = value;
            }
        }
        protected int Num6
        {
            get;
            private set;
        }
        private int Num7
        {
            get;
            set;
        }
    }
}