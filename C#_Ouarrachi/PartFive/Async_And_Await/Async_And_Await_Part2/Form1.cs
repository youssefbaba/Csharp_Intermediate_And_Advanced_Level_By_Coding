namespace Async_And_Await_Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "Processing File , Please await...";
            int numberCharacters = await Task.Run(() => CountCharacters());
            labelDisplay.Text = $"{numberCharacters} characters in file";
        }
        */
        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "Processing File , Please await...";
            int numberCharacters = await CountCharactersAsync();
            labelDisplay.Text = $"{numberCharacters} characters in file";
        }
        private int CountCharacters()
        {
            string contentFile;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Youssef Baba\Desktop\My_Computer\index.html"))
            {
                contentFile = streamReader.ReadToEnd();
                Thread.Sleep(5000);
            }
            return contentFile.Length;
        }
        private Task<int> CountCharactersAsync()
        {
            return Task.Run(() => CountCharacters());
        }
    }
}