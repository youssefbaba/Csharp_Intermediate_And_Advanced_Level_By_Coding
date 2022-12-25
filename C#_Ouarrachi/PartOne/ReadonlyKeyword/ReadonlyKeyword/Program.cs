namespace ReadonlyKeyword
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             - Readonly field : we can get value of readonly field after its first initialization , bu we cannot change its value after its first initialization.
             - We can initialize readonly field in constructor or variable initializer (in declaration time) or init-only setter.
             - Readonly field is not static field.
             - Readonly can take reference type as a value.
             
             */
            //Person person1 = new Person("David");  
            Person person2 = new Person("David" , 25);  
            
        }
    }
}