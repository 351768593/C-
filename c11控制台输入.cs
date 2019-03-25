using System;

namespace c11
{
    class C11
    {
        public static void run()
        {
            string line = Console.ReadLine();
            Console.WriteLine("读到的内容是 "+line);
            foreach(char c in line.ToCharArray())
            {
                printKey(c);
            }
            
            while(true){
                printKey((char)Console.Read()); }
             
            while(true){
                printKey(Console.ReadKey().KeyChar); }
        }

        public static void printKey(char c)
        {
            Console.WriteLine("char == " +
                (c == '\r' ? "\\r" :
                        (c == '\n' ? "\\n" : 
                        "" + (c=='\t'?"\\t":""+ c))));
        }
    }
}