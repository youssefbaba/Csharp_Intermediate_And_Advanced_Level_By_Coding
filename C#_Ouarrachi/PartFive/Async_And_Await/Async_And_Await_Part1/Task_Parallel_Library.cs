namespace Async_And_Await_Part1
{
    public class Task_Parallel_Library
    {
        static async Task Main(string[] args)
        {
            /*
            Task task1 = new Task(() => Work(1)); // Creation of the task1
            task1.Start();    // Execution of the task1
            task1.Wait();   //  Wait method is necessary to prevent the task2 from executing before the task1 finishes execution.
            Task task2 = new Task(() => Work(2));   // Creation of the task2
            task2.Start();    //  Execution of the task2
            */


            //Task.Run(() => Work(3));  // Creation and Execution the instance of Task at the same time. and returns a Task object
            await Task.Run(() => Work(3)).ContinueWith((task) => Console.WriteLine("Work finished."));          // Creation and Execution the instance of Task at the same time. and returns a Task object
            Task.Factory.StartNew(() => Work(4)).ContinueWith((task) => Console.WriteLine("Work finished."));   // Creation and Execution the instance of Task at the same time. and returns a Task object


            int randomNumber = await Task.Run(() => RandomNumber());
            Console.WriteLine($"randomNumber = {randomNumber}");


            Console.ReadLine();
        }
        static void Work(int id)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Id: {id}");
                Thread.Sleep(500);
            }
        }
        static int RandomNumber()
        {
            Random random= new Random();
            return random.Next(0, 10);
        }
    }
}