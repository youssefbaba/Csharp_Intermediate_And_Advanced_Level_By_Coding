using System.Reflection;

namespace Late_Binding_Using_Reflection
{
    public class TestCustomer
    {
        /*
         - Difference between early and late binding :
            - 1 : Early binding can flag errors at compile time. with late binding there is a risk of run time exceptions.
            - 2 : Early binding is much better for peformance and should always be preffered over late binding ,
                  Use late binding only when working with an objects that are not available at compile time.

         */
        static void Main(string[] args)
        {
            /*
            // Early binding : at compile time we have the information about this customer class .
            Customer customer = new Customer();
            string fullName = customer.GetFullName("John", "Doe");
            Console.WriteLine($"Full Name = {fullName}");
            */


            // Late binding : only when we don't have the knowledge of the class for which we are creating an instance.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("Late_Binding_Using_Reflection.Customer");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMehod = customerType.GetMethod("GetFullName");
            MethodInfo displayMethod = customerType.GetMethod("Display");
            //object[] parameters = new object[] { "John", "Doe" };
            string[] parameters = new string[] { "John", "Doe" };
            string fullName =  (string)getFullNameMehod.Invoke(customerInstance, parameters);
            Console.WriteLine($"Full Name = {fullName}");
            displayMethod.Invoke(null, null);




        }
    }
}