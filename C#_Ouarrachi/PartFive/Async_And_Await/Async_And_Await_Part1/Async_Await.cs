namespace Async_And_Await_Part1
{
    public class Async_Await
    {
        static async Task Main(string[] args)
        {
            /*
            // First Way : when we have void as retutn type of DownloadCutomerName method :
            List<string> customerNames = new List<string>();
            Task task1 = new Task(() => DownloadCutomerName(customerNames));
            task1.Start();
            await task1;
            DisplayNames(customerNames);
            Console.WriteLine("End.");
            */


            /*
            // Second Way : when we have void as retutn type of DownloadCutomerName method :
            List<string> customerNames = new List<string>();
            await Task.Run(() => DownloadCutomerName(customerNames));
            DisplayNames(customerNames);
            Console.WriteLine("End.");
            */


            /*
            // First Way : when we have List<string> as retutn type of DownloadCutomerName method :
            List<string> customerNames;
            var task1 = new Task<List<string>>(() => DownloadCutomerName());
            task1.Start();
            customerNames = await task1;
            DisplayNames(customerNames);
            Console.WriteLine("End.");
            */


            /*
            // Second Way : when we have List<string> as retutn type of DownloadCutomerName method :
            List<string> customerNames ;
            customerNames = await Task<List<string>>.Run(() => DownloadCutomerName());
            DisplayNames(customerNames);
            Console.WriteLine("End.");
            */


            /*
            List<string> customerNames;
            customerNames = await DownloadCutomerName();
            DisplayNames(customerNames);
            Console.WriteLine("End.");
            */

            var listOfTasks = new List<Task<List<string>>>();
            listOfTasks.Add(Task.Run(DownloadCutomerName));
            listOfTasks.Add(Task.Run(DownloadCutomerName));
            listOfTasks.Add(Task.Run(DownloadCutomerName));
            listOfTasks.Add(Task.Run(DownloadCutomerName));
            listOfTasks.Add(Task.Run(DownloadCutomerName));
            Task.WaitAll(listOfTasks.ToArray());
            foreach (var task in listOfTasks)
            {
                if (task.IsCompletedSuccessfully)
                {
                    DisplayNames(await task);
                }
            }
        }

        /*
        static void DownloadCutomerName(List<string> customerNames)
        {
            Console.WriteLine("Downloading...");
            if (customerNames == null)
            {
                customerNames = new List<string>();
            }
            for (int i = 0; i < 20; i++) // 10s
            {
                customerNames.Add($"Name {i}");
                Thread.Sleep(100);
            }
        }
        */

        /*
        static List<string> DownloadCutomerName()
        {
            Console.WriteLine("Downloading...");
            List<string> customerNames = new List<string>();
            for (int i = 0; i < 20; i++) // 10s
            {
                customerNames.Add($"Name {i}");
                Thread.Sleep(100);
            }
            return customerNames;
        }
        */

        static Task<List<string>> DownloadCutomerName()
        {
            Console.WriteLine("Downloading...");
            List<string> customerNames = new List<string>();
            for (int i = 0; i < 20; i++) // 10s
            {
                customerNames.Add($"Name {i}");
                Thread.Sleep(100);
            }
            return Task.FromResult(customerNames);      // Task<List<string>>
        }
        static void DisplayNames(List<string> customerNames)
        {
            foreach (var name in customerNames)
            {
                Console.WriteLine($"Customer {customerNames.FindIndex((str) => str.Equals(name))} : {name}");
            }
        }
    }
}
