namespace Async_And_Await_Part4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn1_Click(object sender, EventArgs e)
        {
            //slabel1.Text = BigLongImportantMethod("David");      // Blocking operation that makes Ui unresponsive.


            /*
            var task = new Task<string>(() => BigLongImportantMethod("David"));ss
            task.Start();
            label1.Text = await task;
            */


            //label1.Text  = await Task.Run(() => BigLongImportantMethod("Marks"));


            //Task.Run(() => BigLongImportantMethod("Adam")).ContinueWith(previousCompletedTask => label1.Text = previousCompletedTask.Result);
            //Task.Run(() => BigLongImportantMethod("Adam")).ContinueWith(async previousCompletedTask => label1.Text = await previousCompletedTask);


            /*
            var task = Task.Run(()=> BigLongImportantMethodAsync("Alice"));
            label1.Text = "Waiting...";
            label1.Text = await task;
            */

            
            CallBigLongImportantMethod();
            label1.Text = "Waiting...";
            

        }
        private string BigLongImportantMethod(string name)
        {
            Thread.Sleep(2000);
            return $"Hello, {name}";
        }
        private Task<string> BigLongImportantMethodAsync(string name)
        {
            Thread.Sleep(2000);
            return Task.Run(() => BigLongImportantMethod(name));
        }
        private async void CallBigLongImportantMethod()
        {
            string result = await BigLongImportantMethodAsync("Bernard");
            label1.Text = result;
        }
    }
}