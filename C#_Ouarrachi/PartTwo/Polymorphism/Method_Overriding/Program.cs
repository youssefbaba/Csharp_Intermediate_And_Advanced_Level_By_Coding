namespace Method_Overriding
{
    internal class Program
    {
        /*
         - Method Overriding : it's an approach of re-implementing a parent classes method under the child class with the same signature.
         - Overloading : 
            1- In this case we define multiple methods with the same name by changing their parameters.
            2- This can be performed either within a class as well as between parent child classes also.
            3- While overloading a parent classes method under the child class , child class doesn't require to take any permission from the parent class.
            4- Overloading is all about defining multiple behaviours to a method.

         - Overriding : 
            1- In this case we define multiple methods with the same name and same parameters.
            2- This can be performed only between parent child classes , can never be performed within the same class.
            3- While overriding a parent classes method under the child class , child class requires a permission from the parent class.
            4- Overriding is all about changing the behaviour of parent's method under child class.

         - If we want to override a parent's method under the child class first that method should be declared by using the virtual modifier in parent class.
         - Overriding a virtual parent's method under child class is optional not mandatory.

         */
        static void Main(string[] args)
        {
            LoadChild child = new LoadChild();  
            child.Show();
            child.Show(10);
            child.Show("string");
            child.Test();
            child.Print();
        }
    }
}