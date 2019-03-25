using System;
using System.Collections.Generic;
using System.Net;

namespace e
{
    interface IMove
    {
        void Move(double x, double y, double z);
    }
    interface IEat
    {
        void DoEat(FoodType food);
    }
    enum FoodType
    {
        Meat,
        Vegetarian,
    }

    abstract class Living // 生物类
    {
        // 所有的生物都有出生日期属性 都有年龄属性
        public DateTime Birthday { get; private set; }
        public TimeSpan Age { get { return DateTime.Now - Birthday; } }
        public float Weight { get; protected set; }

        public Living(DateTime birthday) { Birthday = birthday; }

        public double X { get; protected set; }
        public double Y { get; protected set; }
        public double Z { get; protected set; }

        // 不同生物都能变重或者变轻
        public void ChangeWeight(float w) { Weight = w; }

    }
    class Human : Living , IEat, IMove // 人类
    {
        public Human(DateTime birthday) : base(birthday) { }
        public void Move(double x, double y, double z)
        {
            Console.WriteLine("人用两条腿走到目的地");
            X = x;Y = y;Z = z;
        }
        public void DoEat(FoodType food)
        {
            Console.WriteLine("人吃"+food.ToString());
        }

        public virtual void Speak(string content)
        {
            Console.WriteLine("人说 : "+content);
        }
    }
    class Dog : Living , IEat, IMove // 狗类
    {
        public Dog(DateTime birthday) : base(birthday) { }
        public void Move(double x, double y, double z)
        {
            Console.WriteLine("狗用四条腿走到目的地");
            X = x; Y = y; Z = z;
        }
        public void DoEat(FoodType food)
        {
            if (food != FoodType.Meat)
                Console.WriteLine("狗吃" + food.ToString());
        }
    }
    class Bird : Living , IEat , IMove // 鸟类
    {
        public Bird(DateTime birthday) : base(birthday) { }
        public void Move(double x, double y, double z)
        {
            Console.WriteLine("鸟用翅膀飞到目的地");
            X = x; Y = y; Z = z;
        }
        public void DoEat(FoodType food)
        {
            if (food != FoodType.Meat)
                Console.WriteLine("鸟吃" + food.ToString());
        }
    }
    class Tree : Living
    {
        public Tree(DateTime birthday) : base(birthday) { }
    }
    
    class Person : Human
    {
        public string Name { get; protected set; }
        public long ID { get; protected set; }
        public Person(DateTime birthday,string name,long id) : base(birthday)
        {
            Name = name;
            ID = id;
        }
    }
    class Student : Person
    {
        public string School { get; protected set; }
        public Student(DateTime birthday,string name, long id, string school)
            : base(birthday,name,id)
        {
            School = school;
        }

        public override void Speak(string content)
        {
            Console.WriteLine("学生说 : "+content);
        }

    }
    class Employee : Person
    {
        public long Order { get; protected set; }
        public string Department { get; protected set; }
        public float Salary { get; protected set; }
        public Employee(DateTime birthday,string name,long id, long order,string department, float salary)
            : base(birthday, name, id)
        {
            Order = order;
            Department = department;
            Salary = salary;
        }

        public override void Speak(string content)
        {
            Console.WriteLine("职员说 : " + content);
        }
    }




    class V
    {
        public int X,Y,Z;
        public virtual void Move(int x,int y,int z)
        {
            Console.WriteLine("交通工具 移动到 指定位置");
            X = x;
            Y = y;
            Z = y;
        }
    }
    class Car : V
    {
        public override void Move(int x, int y, int z)
        {
            Console.WriteLine("汽车开到指定位置");
            X = x;
            Y = y;
            Z = z;
        }
    }
}