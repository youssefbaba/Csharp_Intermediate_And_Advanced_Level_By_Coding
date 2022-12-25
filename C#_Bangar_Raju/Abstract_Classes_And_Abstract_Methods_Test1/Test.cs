namespace Abstract_Classes_And_Abstract_Methods_Test1
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Parent parent1 = new Parent();
            Child child1 = new Child();

            parent1.Show(); // from Parent
            parent1.Test(); // from Parent

            child1.Test(); //  from Child
            child1.Show(); //  from Parent

            Parent parent2 = new Child();
            parent2.Show(); // from Parent 
            parent2.Test(); // from Child


            //AbsParent absParent = new AbsParent();  // Cannot create an instance of the abstract type
            AbsChild absChild = new AbsChild();
            absChild.Add(20, 10);
            absChild.Sub(20, 10);
            absChild.Mul(20, 10);
            absChild.Div(20, 10);

            AbsParent absParent1 = new AbsChild();
            absParent1.Add(30, 10);
            absParent1.Sub(30, 10);
            absParent1.Mul(30, 10);
            absParent1.Div(30, 10);




        }
    }
}