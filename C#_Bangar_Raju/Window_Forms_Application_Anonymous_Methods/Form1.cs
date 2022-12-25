namespace Window_Forms_Application_Anonymous_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Text = "Show Message";
            button1.Size = new Size(118, 46);
            button1.Left = (ClientSize.Width - button1.Width) / 2;
            button1.Top = (ClientSize.Height - button1.Height) / 2;
            Controls.Add(button1);

            //button1.Click += new EventHandler(showMessage_Click);
            /*
            button1.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Hi Youssef Baba");
            };
            */
            button1.Click += delegate
            {
                MessageBox.Show("Hi Youssef Baba");
            };
        }
        private void showMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi Youssef Baba");
        }

    }
}