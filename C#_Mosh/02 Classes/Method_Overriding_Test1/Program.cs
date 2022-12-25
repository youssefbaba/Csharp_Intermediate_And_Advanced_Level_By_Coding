namespace Method_Overriding_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://www.youtube.com/watch?v=7u4HqIt_XBY&t=59s
             Parent obj = new Child();
             - Even though your reference is of the Parent type, the underlying object is Child and any overridden members in the derived class Child will be used instead of those on Base, even though you are trying to use Parent.
             - In the case of member hiding using the new keyword, if you have a reference to the base type it will skip any derived classes that are hiding the members .
       
             */
            User me = new User("Youssef", "Baba");
            Console.WriteLine(me);
            User you = new User("Mohamed", "Zidani");
            Console.WriteLine(me.Equals(you)); // False
            User he = new User("Youssef", "Baba");
            Console.WriteLine(me.Equals(he)); // True


            Person person1 = new Person("Youssef", 25);
            person1.Work(); // It works...
            person1.Display(); // Is person


            Employee employee1 = new Employee(1000, "Enginer", "Mohamed", 25);
            employee1.Work(); // It earns...
            employee1.Display(); // Is employee


            Person person2 = new Employee(1200, "Enginer", "Youssef", 25);
            person2.Work(); // It works...
            person2.Display(); // Is employee


            Person person3 = new Student(17 , "Youssef" , 25);
            person3.Display(); // Is student


            Person person4 = new Manager(1500, "Designer", "Omar", 22);
            person4.Display(); // Is manager


            Employee employee2 = new BranchManager(1500, "Marketer", "Hassna", 22);
            employee2.Display(); // Is manager

        }
    }
}