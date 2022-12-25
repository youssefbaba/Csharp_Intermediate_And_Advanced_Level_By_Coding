namespace Test2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            ListInt myList = new ListInt();
            myList.Add(45);
            myList.Add(10);
            myList.Add(16);
            myList.Add(78);
            myList.Add(18);
            myList.Display(myList);


            ListString myList2 = new ListString();
            myList2.Add("Toyota");
            myList2.Add("Honda");
            myList2.Add("Ford");
            myList2.Add("Peugeot");
            myList2.Display(myList2);
            */


            GenericClass<int> genericInt = new GenericClass<int>();
            genericInt.Add(45);
            genericInt.Add(10);
            genericInt.Add(16);
            genericInt.Add(78);
            genericInt.Add(18);
            genericInt.Display(genericInt);


            GenericClass<string> genericString = new GenericClass<string>();
            genericString.Add("Toyota");
            genericString.Add("Honda");
            genericString.Add("Ford");
            genericString.Add("Peugeot");
            genericString.Display(genericString);


        }
    }
}
