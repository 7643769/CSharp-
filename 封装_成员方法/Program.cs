namespace 封装_成员方法
{
    class Person
    {
        public string name;
        public int age;
        public Person[] friends;
        public string position;
        public Food food;
        public void Speak(string str)
        {
            Console.WriteLine($"{name}说{str}");
        }
        public void Walk(string pos)
        {
            Console.WriteLine($"{name}去{pos}了");
        }
        public void Eat(Food food)
        {
            this.food = food;
            Console.WriteLine($"{name}吃{food}");
        }
        public void AddFriend(Person p)
        {
            if(friends == null)
            {
                friends = new Person[] { p };
            }
            else
            {
                Person[] newFriends = new Person[friends.Length + 1];
                for (int i =0;i<friends.Length;i++)
                {
                    newFriends[i]=friends[i];
                }
                newFriends[newFriends.Length - 1] = p;
                friends = newFriends;
            }
        }
        public bool IsAdult()
        {
            return age >= 18;
        }
    }
    class Student
    {
        public string name;
        public int age;
        public Person[] friends;
        public string position;
        public Food food;
        public string major;
        public void Eat(Food food)
        {
            this.food = food;
            Console.WriteLine($"{name}吃{food}");
        }
        public void Study(string major)
        {
            this.major = major;
            Console.WriteLine($"{name}正在上{major}课");
        }
    }
    class Food
    {
        public string name;
        public double hot;
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员方法");
            Person p = new Person();
            p.name = "阿源";
            p.Speak("666");
            p.age = 22;
            if (p.IsAdult())
            {
                p.Speak("我想找工作");
            }
            Person p2 = new Person();
            p2.name = "芯儿";
            p2.age = 20;
            p.AddFriend(p2);
        }
    }
}
