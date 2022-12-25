namespace Delegates
{
    // Defining a delegate :
    public delegate void DelegateOne(int value1, int value2);
    public delegate string DelegateTwo(string sentence);


    public class DelegateClass
    {
        /*
         - Delegate : it's a type safe function pointer .
         - A delegate holds the reference of a method and then calls the method for execution.
         - To call a method by using a delegate we have 3 steps : 
            - Step 1 : Define a delegate.
                - <Modifier> delegate void|type <Name>(<parameter list>);

            - Step 2 : Instantiating the delegate.
            - Step 3 : call the delegate by passing required parameter values , so that internally the method wich is bound with the delegate gets executed.





         */
        static void Main(string[] args)
        {
            /*
            // calling the method by using the instance type or class :
            DelegateClass obj = new DelegateClass();
            obj.AddNumbers(10,20);
            string str = SayHello("Youssef");
            Console.WriteLine(str);
            */

            
            DelegateOne obj = new DelegateOne(new DelegateClass().AddNumbers); // Instantiating the delegate 
            //obj(10, 20);      // First way of calling the delegate
            obj.Invoke(10, 20);     // Second way of calling the delegate


            DelegateTwo obj1 = new DelegateTwo(SayHello);
            //string str = obj1("Youssef");     // First way of calling the delegate
            string str = obj1.Invoke("Youssef");    // Second way of calling the delegate
            Console.WriteLine(str);


        }
        public void AddNumbers(int number1, int number2) // Instance Method
        {
            Console.WriteLine(number1 + number2);
        }
        public static string SayHello(string name)  // Static Method
        {
            return $"Hello {name}";
        }
    }
}