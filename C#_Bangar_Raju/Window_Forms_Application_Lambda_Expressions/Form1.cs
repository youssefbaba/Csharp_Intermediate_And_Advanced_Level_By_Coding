namespace Window_Forms_Application_Lambda_Expressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Show Message";
            button.Size = new Size(119, 43);
            button.Left = (ClientSize.Width - button.Width) / 2;
            button.Top = (ClientSize.Height - button.Height) / 2;
            Controls.Add(button);
            button.Click += (sender,e)=>
            {
                MessageBox.Show("Hi Youssef Baba");
            };
        }
    }
}