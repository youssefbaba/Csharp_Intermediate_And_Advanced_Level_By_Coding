namespace Async_await
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            /*
             - Link1 : https://www.youtube.com/watch?v=JwhkX3mIwRo
             */


            //List<string> customerNames;

            /*
            Task task = new Task(() => DownloadCustomerName(customerNames));
            task.Start();
            task.Wait();
            */

            //await Task.Run(() => DownloadCustomerName(customerNames));

            //customerNames = await Task.Run(DownloadCustomerName);

            List<Task<List<string>>> listOfTasks = new List<Task<List<string>>>();
            listOfTasks.Add(Task.Run(DownloadCustomerName));
            listOfTasks.Add(Task.Run(DownloadCustomerName));
            listOfTasks.Add(Task.Run(DownloadCustomerName));
            Task.WaitAll(listOfTasks.ToArray());

            for (int i = 0; i < listOfTasks.Count; i++)
            {
                if (listOfTasks[i].IsCompletedSuccessfully)
                {
                    Console.WriteLine($"Displaying list {i + 1}");
                    DisplayNames(listOfTasks[i].Result);
                }
            }


            Console.WriteLine("End.");
            Console.ReadLine();
        }
        private static Task<List<string>> DownloadCustomerName()
        {
            Console.WriteLine("Downloading...");
            List<string> customerNames = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                customerNames.Add($"Name {i}");
                Thread.Sleep(1);
            }
            return Task.FromResult(customerNames);
        }
        //private static void DownloadCustomerName(List<string> customerNames)
        //{
        //    Console.WriteLine("Downloading...");
        //    if (customerNames == null)
        //    {
        //        customerNames = new List<string>();
        //    }

        //    for (int i = 0; i < 100; i++)
        //    {
        //        customerNames.Add($"Name {i}");
        //        Thread.Sleep(100);
        //    }
        //}
        private static void DisplayNames(List<string> customerNames)
        {
            if (customerNames.Count == 0)
            {
                Console.WriteLine("Empty list");
                return;
            }

            foreach (string name in customerNames)
            {
                Console.WriteLine($"Customer {customerNames.FindIndex((str) => str.Equals(name))} : {name}");
            }
        }
    }
}