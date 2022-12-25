using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHtml("https://www.youtube.com");
            //DownloadHtmlAsync("https://www.youtube.com");
            Task<string> taskGetHtml = GetHtmlAsync("https://www.youtube.com");
            MessageBox.Show("Hello World");
            string html = await taskGetHtml;
            MessageBox.Show(html.Substring(0, 10));

        }
        private async Task<string> GetHtmlAsync(string url)
        {
            WebClient webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }

        private string GetHtml(string url)
        {
            WebClient webClient = new WebClient();
            return webClient.DownloadString(url);
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
        private void DownloadHtml(string url)
        {
            WebClient webClient = new WebClient();
            string html = webClient.DownloadString(url);

            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Youssef Baba\Desktop\My_Computer\index.html", true))
            {
                streamWriter.Write(html);
            }
        }
    }
}
