using System;

namespace c34
{
    class C
    {
        public int[] nums;
        
        public int this[int index]
        {
            get
            {
                return nums[index];
            }
            set
            {
                nums[index] = value;
            }
        }
        public int this[string index]
        {
            get
            {
                try
                {
                    return nums[int.Parse(index)];
                }
                catch(Exception e)
                {
                    ;
                }
                return 0;
            }
        }
    }
    class C34
    {
        public static void run()
        {
            ;
        }
    }
}