namespace StaticClass
{
    public class Program
    {
        static void Main(string[] args)
        {
           /*
            - Static Class contains only static members.
            - Instance Class contains static and instance members.
            - Static Class we cannot instantiate an object from it
            - Instance Class we can instantiate an object from it.
            
            */


            InstanceClass obj = new InstanceClass();
            //StaticClass obj1 = new StaticClass();  // Error : we cannot create an instance for static class

        }
    }
}