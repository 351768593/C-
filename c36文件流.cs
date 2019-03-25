using System;
using System.IO;

namespace c36
{
    class C36
    {
        public static void run()
        {
            
            try
            {
                FileStream stream = File.Open("D:\test.txt", FileMode.Create);
                // FileStream stream = File.OpenWrite("D:\test.txt");
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine("123");

                writer.Flush();
                writer.Close();
                stream.Flush();
                stream.Close();
            }
            catch(Exception e)
            {
                ;
            }

        }
        public static void run2()
        {
            try
            {
                FileStream fs = File.OpenRead("D:/test.txt");
                StreamReader ifs = new StreamReader(fs);
                while(!ifs.EndOfStream)
                {
                    string line = ifs.ReadLine();
                    Console.WriteLine(line);
                }

                File.Create("D:/test2.txt");
            }
            catch(Exception e)
            {
                ;
            }
        }
    }
}