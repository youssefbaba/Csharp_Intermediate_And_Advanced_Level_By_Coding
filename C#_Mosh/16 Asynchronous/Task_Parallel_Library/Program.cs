namespace Task_Parallel_Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Task task1 = new Task(() => Work(1));
            task1.Start();
            // task1.Wait();


            Task task2 = new Task(() => Work(2));
            task2.Start();
            // task2.Wait();

            */


            /*

            Task.Run(() => Work(3)).ContinueWith((task) => Console.WriteLine("work finished"));
            Task.Run(() => Work(4)).ContinueWith((task) => Console.WriteLine("work finished"));

            */

            /*
             
            Task.Factory.StartNew(() => Work(5));
            Task.Factory.StartNew(() => Work(6));

            */

            var source = new CancellationTokenSource();
            var token = source.Token;
            Task.Run(() => Work(token), token);

            Thread.Sleep(500);
            source.Cancel();
            Console.WriteLine("Work canceled");
            //Console.ReadLine();
        }

        private static void Work(CancellationToken token)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Work canceled");
                    return;
                }
                Console.WriteLine($"Method running .. {i}");
            }
        }
    }
}