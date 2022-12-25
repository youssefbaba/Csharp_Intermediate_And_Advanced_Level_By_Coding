namespace Method_Overriding_Vs_Method_Hiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            - link1 : https://www.youtube.com/watch?v=7u4HqIt_XBY&t=59s
            Parent obj = new Child();
            - Even though your reference is of the Parent type, the underlying object is Child and any overridden members in the derived class Child will be used instead of those on Base, even though you are trying to use Parent.
            - In the case of member hiding using the new keyword, if you have a reference to the base type it will skip any derived classes that are hiding the members .
            - Method Overriding => at run time
            - Method Hiding => at complie time
            */

            BaseClass baseClass = new DerivedClass(); // baseClass is of type BaseClass at complie time and is of type DerivedClass at run time
            baseClass.PrintOne(); // I am a Derived Class From PrintOne
            baseClass.PrintTwo(); // I am a Base Class From PrintTwo

            BaseClass baseClass1 = new BaseClass();
            baseClass1.PrintOne(); // I am a Base Class From PrintOne
            baseClass1.PrintTwo(); // I am a Base Class From PrintTwo

            DerivedClass derivedClass = new DerivedClass(); 
            derivedClass.PrintOne(); // I am a Derived Class From PrintOne
            derivedClass.PrintTwo(); // I am a Derived Class From PrintTwo


        }
    }
}