namespace 封装_成员变量和访问修饰符
{
    #region  概念
    //enum E_SexType
    //{
    //    Man,
    //    Woman,
    //}
    //struct Position
    //{

    //}
    //class Person
    //{
    //    public string name = "阿源";
    //    public int age;
    //    public E_SexType sex;
    //    public Person girlFriend;
    //    public Person[] boyFriend;
    //    public Position pos;

    //}
    #endregion
    class Person
    {
        public string name;
        public double height;
        public int age;
        public string adress;

    }
    class Student
    {
        public string name;
        public int num;
        public int age;
        public Student deskmate;
        public void Study()
        {
            Console.WriteLine($"{name}正在学习......");
        }

    }
    enum E_Major
    {
        math,
        english,
        computer
    }
    class Class
    {
        public E_Major MajorName;
        public int[] roomspace;
        public Student[] stu;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 概念
            //Console.WriteLine("Hello, World!");
            //Person p = new Person();
            ////看默认值
            //Console.WriteLine(default(int));
            #endregion
            Person a = new Person();
            a.age = 22;
            a.name = "阿源";
            Person b = new Person();
            b.name = "温时清";
            b.height = 172;

            Student s = new Student();
            s.deskmate.deskmate.age = 21;
            s.age = 20;

            Class c = new Class();
            c.MajorName = E_Major.computer;

        }
    }
}
