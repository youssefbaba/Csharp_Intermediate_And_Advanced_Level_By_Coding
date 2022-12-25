namespace Inheritance_Part2
{
    internal class Child : Parent
    {
        // Fields
        public float Note;

        // Constructors
        public Child() // parameter less constructor
        {
            Console.WriteLine("child parameter less constructor is called");
        }
        public Child(string firstname, string lastname, float wealth, float note) : base(firstname, lastname, wealth)  // parameterized constructor
        {
            Console.WriteLine("child parameterized constructor is called");
            Note = note;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Note = {Note}");
        }

        // Methods
        public void Test4()
        {
            Console.WriteLine("Method 4");
        }
        static void Main()
        {
            
            // Object => Parent => Child

            Object obj = new Object();
            Console.WriteLine(obj.GetType());
            Parent parent = new Parent();
            Console.WriteLine(parent.GetType());
            Child child = new Child();
            Console.WriteLine(parent.GetType());


            Child child1 = new Child();
            child1.Display(); 
            Child child2 = new Child("Youssef", "Baba", 12000000.01254f, 17.89f);
            child2.Display();

        }
    }
}
