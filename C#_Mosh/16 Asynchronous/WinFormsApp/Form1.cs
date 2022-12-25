namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        /*
         - link1 : https://www.youtube.com/watch?v=C5VhaxQWcpE&list=PLAC325451207E3105&index=101
         */
        public Form1()
        {
            InitializeComponent();
        }

        private int CounterCharacters()
        {
            int count = 0;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Youssef Baba\Desktop\My_Computer\Data.txt"))
            {
                string content = streamReader.ReadToEnd();
                count = content.Length;
                // another solution is when we ave a big file 
                Thread.Sleep(5000);
            }
            return count;
        }
        //private void buttonProcessFile(object sender, EventArgs e)
        private async void buttonProcessFile(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CounterCharacters);
            task.Start();
            //int count = await task;
            labelCount.Text = "Processing file please wait...";
            textBoxDisplay.Text = "First Statement";
            int count = await task;
            labelCount.Text = $"{count}characters in file";
            textBoxDisplay.Text = "Second Statement";
            //Thread.Sleep(10000);
        }
    }
}