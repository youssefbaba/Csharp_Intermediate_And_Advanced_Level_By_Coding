using System.IO;
using System.Net;

namespace Async_And_Await_Part3
{
    /*
     - Synchronous Program Execution :
        - Program is executed line by line one at a time.
        - When a function is called , program execution has to wait until the function returns before it continues execution to the next line.
            - For exmaple :
                Line1;
                Line2;
                TimeConsuminProcces(); 3s (blocking operation)
                Line4;
     - Asynchronous Program Execution :
        - When a function is called , program execution continues to the next line , without waiting for the function to complete.
     - Benefits of Asynchronous Programming :
        - Asynchronous Programming improves responsiveness of your application
     - When to use Asynchronous Programming :
        - we use Asynchronous Programming any time when we have blocking operation such as :
            - Accessing the web
            - Working with files and databases
            - Working with images 
            - ... 
     - Task is an object that encapsulates the state of an asynchronous operation.
     - Whenever we are using blocking operations we should use async and await.


     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Click(object sender, EventArgs e)
        {
            //DownloadHtml("https://www.youtube.com/");
            //DownloadHtmlAsync("https://www.youtube.com/");
            /*
            string html = GetHtml("https://www.youtube.com/");
            MessageBox.Show(html.Substring(2 ,8));
            */
            var getHtmlTask =  GetHtmlAsync("https://www.youtube.com/");
            MessageBox.Show("Waiting for the task to complete...");
            string html = await getHtmlTask;
            MessageBox.Show(html.Substring(2, 8));
        }
        private void DownloadHtml(string url)
        {
            WebClient webClient = new WebClient();
            string html = webClient.DownloadString(url);
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Youssef Baba\Desktop\My_Computer\index.html", true))
            {
                streamWriter.Write(html);
            }
        }
        private async Task DownloadHtmlAsync(string url)
        {
            WebClient webClient = new WebClient();
            string html = await webClient.DownloadStringTaskAsync(url);
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Youssef Baba\Desktop\My_Computer\index.html", true))
            {
                await streamWriter.WriteAsync(html);
            }
        }
        private string GetHtml(string url)
        {
            WebClient webClient = new WebClient();
            return webClient.DownloadString(url);
        }
        private async Task<string> GetHtmlAsync(string url)
        {
            WebClient webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}