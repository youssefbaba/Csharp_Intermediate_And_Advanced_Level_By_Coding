namespace Method_Hiding
{ 
    internal class Program
    {
        /*
         - Method overriding is an approach of re-implementing a parent classes method under the child class exactly with the same name and same signature. 
         - Method hiding is also an approach of re-implementing a parent classes method under the child class exactly with the same name and signature.
         - In the first case child class re-implements it's parent class methods which are declared as virtual, 
          where as in the second case child class can re-implement any parent class method even if the method is not declared as virtual. 
         - We can re-implement a parent classes method under child class by using two approaches :
            1- Method Overriding : With permission
            2- Method Hiding : without permission
         - After re-implementing parent classes methods under child classes the child class instance will start calling the local methods only
           that is the re-implemented methods , but if required in any case we can also call the parent classes method from child classes by using
           two approaches .
            1- By creating the instance of parent class under child class we can call parent's method from child class.
            2- By using the base keyword also we can call parent's method from child class , but keywords like this and base can't be used from static blocks.
         - A parent class reference even if created by using the child class instance can't access any members that are purely defined under child class ,
           but can call overriden members of child class , because overriden members are not considered as pure child class members, but members which are re-implemented 
           by using the approach of hiding are considered as pure child class members and not accessible to parent's references.

          
         */
    }
}