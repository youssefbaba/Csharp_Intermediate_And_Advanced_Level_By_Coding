namespace BaseKeyword
{
    internal class Circle : Shape
    {
        // Fields
        double _radius;


        // Constrcutors
        public Circle()
        {
            Console.WriteLine("Parameter-less constructor of child class invoked");
        }
        public Circle(int x, int y , double radius) : base(x, y)
        {
            Console.WriteLine("Parameterized constructor of child class invoked");
            _radius = radius;
        }


        // Methods
        public void Display()
        {
            //Console.WriteLine($"{base.Print()} ; Radius = {_radius}");
            Console.WriteLine($"{Print()} ; Radius = {_radius}");
        }
    }
}
