using System;

namespace a01_08
{
    class Lamp
    {
        public static int U=220;
        public static int I=1;
        public bool status;

        public Lamp()
        {
            status = false;
        }
        public Lamp(bool s)
        {
            status = s;
        }

        public static int W()
        {
            return U * I;
        }

        public void LightOn()
        {
            status = true;
        }
        public void LightOff()
        {
            status = false;
        }

        public void Status()
        {
            // Console.WriteLine("电灯当前的状态是 : " + (status?"开":"关"));
            if (status)
            {
                Console.WriteLine("电灯当前的状态是 开");
            }
            else
            {
                Console.WriteLine("电灯当前的状态是 关");
            }
        }
    }
    class Circular
    {
        public double radius;
        public double x;
        public double y;

        public double Area()
        {
            return 3.14 * radius * radius;
        }
        public void SetRadius(double area)
        {
            radius = Math.Sqrt(area / 3.14);
        }
        public void Info()
        {
            Console.WriteLine("r=="+radius+" a=="+Area() );
        }
    }
}