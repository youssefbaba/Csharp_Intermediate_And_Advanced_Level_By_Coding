namespace Indexers_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://www.youtube.com/watch?v=huqfkUV3Ha8
             - link2 : https://www.youtube.com/watch?v=Js24GMjfQKI
             - link3 : https://www.youtube.com/watch?v=wvDAGpYtdv4 

              - declaration of indexers 
                <modifier> <type> this ( <parameter list> )
                {
                  get { statements ... } // get accessor
                  set { statements ... } // set accessor
                }
             */

            Departement departement = new Departement();
            Console.WriteLine($"Id = {departement[1].Id} , Name = {departement[2].EmployeeName} , Salary = {departement[1].Salary}");
            Console.WriteLine($"Id = {departement["Chris"].Id} , Name = {departement["Chris"].EmployeeName} , Salary = {departement["Chris"].Salary}");

            Worker worker = new Worker(1, "John", "Manager", "Sales", "Madrid" ,200000.00);
            Console.WriteLine($"WorkerNumber = {worker[0]}");
            Console.WriteLine($"WorkerName = {worker[1]}");
            Console.WriteLine($"WorkerJob = {worker[2]}");
            Console.WriteLine($"DepartementName = {worker[3]}");
            Console.WriteLine($"DepartementLocation = {worker[4]}");
            Console.WriteLine($"Salary = {worker[5]}");

            Console.WriteLine("-----------------------------");

            worker[0] = 2;
            worker[1] = "Sam";
            worker[2] = "Sunior Manager";
            worker[5] = 250000.00;
            Console.WriteLine($"WorkerNumber = {worker[0]}");
            Console.WriteLine($"WorkerName = {worker[1]}");
            Console.WriteLine($"WorkerJob = {worker[2]}");
            Console.WriteLine($"DepartementName = {worker[3]}");
            Console.WriteLine($"DepartementLocation = {worker[4]}");
            Console.WriteLine($"Salary = {worker[5]}");

            Console.WriteLine("-----------------------------");

            Worker worker1 = new Worker(3, "Jim", "Developer", "Developement", "Madrid", 100000.00);
            Console.WriteLine($"WorkerNumber = {worker1["WorkerNumber"]}");
            Console.WriteLine($"WorkerName = {worker1["WorkerName"]}");
            Console.WriteLine($"WorkerJob = {worker1["WorkerJob"]}");
            Console.WriteLine($"DepartementName = {worker1["DepartementName"]}");
            Console.WriteLine($"DepartementLocation = {worker1["DepartementLocation"]}");
            Console.WriteLine($"Salary = {worker1["Salary"]}");

            Console.WriteLine("-----------------------------");

            worker1["WorkerNumber"] = 4;
            worker1["WorkerName"] = "Chris";
            worker1["WorkerJob"] = "Sunior Developer";
            worker1["Salary"] = 120000.00;
            Console.WriteLine($"WorkerNumber = {worker1["WorkerNumber"]}");
            Console.WriteLine($"WorkerName = {worker1["WorkerName"]}");
            Console.WriteLine($"WorkerJob = {worker1["WorkerJob"]}");
            Console.WriteLine($"DepartementName = {worker1["DepartementName"]}");
            Console.WriteLine($"DepartementLocation = {worker1["DepartementLocation"]}");
            Console.WriteLine($"Salary = {worker1["Salary"]}");




        }
    }
}