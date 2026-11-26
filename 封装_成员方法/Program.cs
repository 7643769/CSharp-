namespace 封装_成员方法
{
    class Person
    {
        public string name;
        public int age;
        public Person[] friends;
        public void Speak(string str)
        {
            Console.WriteLine($"{name}说{str}");
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
