namespace Inheritance_Part1
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



             */

            ClassTwo classTwo = new ClassTwo();
            classTwo.Test1();
            classTwo.Test2();
            classTwo.Test3();


            ClassOne classOne = new ClassOne();
            classOne.Test1();
            classOne.Test2();
            // classOne.Test3(); // Compile time error : because parent class cannot access child class members 


            
            //ClassOne p = new ClassTwo();
            ClassOne p; // p is a variable of ClassOne
            ClassTwo c = new ClassTwo(); // c is an instance of ClassTwo
            p = c; // p is a reference of parent class created using child class instance
            p.Test1();
            p.Test2();
            // p.Test3();  // complie time error because we cannot call any pure child class member by using the reference of parent class
            





        }
    }
}