namespace Anonymous_Methods
{
    /*
       - Anonymous Methods : without binding named method to the delegate we can bind a code block to the delegate.
       - Anonymous Methods = Method without name that contains only the body 
       - Advantages of anonymous method is : 
            - lesser typing work , we don't require to specify modifiers , return type , method name 
            - we don't require to look somewhere for the logic .
        - Generally anonymous method not suggested .
    */



    public delegate string DelegateOne(string name);    // Defining a delegate

    public class AnonymousMethods
    {
        // Methods

        /*
        public static string Greetings(string name)
        {
            return $"Hello {name} good morning";
        }
        */

        static void Main(string[] args)
        {

            /*
            //DelegateOne obj = new DelegateOne(Greetings);      // First way of Instantiating the delegate
            DelegateOne obj = Greetings;                         // Second way of Instantiating the delegate
            //string sentence = obj("Youssef");           // First way of Calling the delegate
            string sentence = obj.Invoke("Youssef");             // Second way of Calling the delegate
            Console.WriteLine(sentence);
            */

            DelegateOne obj1 = delegate(string name)   // Anonymous Method : Method without name just only a body
            {
                return $"Hello {name} good morning";
            };
            string sentence1 = obj1.Invoke("Youssef");
            Console.WriteLine(sentence1);
        }
    }
}