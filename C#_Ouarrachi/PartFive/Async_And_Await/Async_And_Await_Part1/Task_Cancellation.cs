namespace Async_And_Await_Part1
{
    public class Task_Cancellation
    {
        static void Main(string[] args)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            Task.Run(() => Test(token) , token);
            Thread.Sleep(1000);
            source.Cancel();
            Console.WriteLine("Work cancelled");

        }
        static void Test(CancellationToken token)
        {
            for (int i = 0; i < 100; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                Console.WriteLine($"Method running... {i}");
                Thread.Sleep(100);
            }
        }
    }
}