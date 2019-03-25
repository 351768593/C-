using System;

namespace c2
{
    class C
    {
        // https://msdn.microsoft.com/zh-cn/library/x53a06bb(VS.80).aspx

        public static void run() // 关键字和标识符
        {
            /* 系统保留的关键字
                abstract	event	    new	            struct
                as	                explicit        null	            switch
                base	                extern	        object	        this
                bool	                FALSE	        operator	throw
                break	            finally	        out
                byte	                fixed	        override	try
                case	                float	        params	        typeof
                catch	            for	            private	        uint
                char	                foreach	        protected	    ulong
                checked	            goto	            public	        unchecked
                class	            if	            readonly    	    unsafe
                const	            implicit	ref	    ushort
                continue            in	            return	        using
                decimal	            int	            sbyte	        virtual
                default	            interface	    sealed	        volatile
                delegate            internal	short	void
                do	                is	            sizeof	        while
                double	            lock	            stackalloc	
                else	                long	            static	
                enum	                namespace	    string
            
            */

            // 如果实在要用到系统保留的关键字作为标识符 
            // 可以在前面加上 @ 符号
            // 不过尽量不要这么写
            int @public=1;

            // 标识符只能由数字、字母、下划线组成
            // 标识符必须由字母或下划线开头
            // 标识符不能是关键字
            /* 
            标识符区分大小写
            Member
            member
            MemBer
            
            五个不同的标识符
            a
            A
            A_
            _A
            _a

            
            */

            /*
            命名时使用大驼峰式命名法
            比如：UserName
            而不是
             */

            /*
            C# 中的语句由分号“;”结束
            */
            int a = 0; // 声明语句
            a = 1; // 赋值语句
            a = 1 + 2; // 右边是表达式语句
            
        }

    }
}