namespace Inheritance_Part2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - Inheritance : 
             - it's a mechanism of consuming the members of one class in another class by establishing parent/child realationship between the classes , which provides re-usability.
             - <modifiers> class <child-class> : <parent-class>
             -  class A { - Members }
                class B : A { - Consuming the members of A from here}

             - In inheritance child class can consume members of it's parent class as if it's the owner of those members , except the private members of parent class.
             - Note 1 : Parent class parameter-less constructor must be accessible to child class , otherwise inheritance will not be possible.
             - Note 2 : Child class constructor calls implicitly to its Parent class parameter-less constructor. 
             - Note 3 : In inheritance child class can access to parent class members but parent class can never access any member that is purely defined under the child class .
             - Note 4 : We can initialize a parent classe variable by using the child class instance to make it as a reference , so that the reference will be consuming the memory of child class instance ,
                        but in this case also we can't call any pure child class members by using the refrence.
             - Note 5 : Every class that is defined by us or pre-defined in the libraries of the language has a default parent class i.e Object class of System namespace,
                        so the members of Objects class (Equals , GetHashCode , GetType , ToString) are accessible from anywhere.
             - Note 6 : Types of inheritance : Single Inheritance , Multiple Inheritance
                        - if a class has one immediate parent class to it we call it as Single Inheritance and if it is more than one immediate parent class to it we call it as Multiple Inheritance.
                        - In Csharp we don't have support multiple inheritance , what we areprovided is only single inheritance.
             - Note 7 : In the second note we learnt whenever child class instance is created , child class constructor will implicitly call it's parent class parameter-less constructor ,
                        where as if the constructor of parent class is parameterized , child class constrcutor can't implicitly call it's parent constructor , so to overcome the problem
                        it is the responsability of the programmer to explicitly call parent classes constructor from child class constructor and pass values to those parameters , To call parent's constructor from child class we need to use the base keyword.
                        


             */

            /*

            object obj = new object(); // Object is the root class and the default parent class of all classes (user-defined and pre-defined classes)
            Console.WriteLine(obj.GetType());
            ClassOne p = new ClassOne();
            Console.WriteLine(p.GetType());
            ClassTwo c = new ClassTwo();
            Console.WriteLine(c.GetType());
          
            */

            ClassTwo child1 = new ClassTwo();
            ClassTwo child2 = new ClassTwo(10);
            ClassTwo child3 = new ClassTwo(20 , 30);








        }
    }
}