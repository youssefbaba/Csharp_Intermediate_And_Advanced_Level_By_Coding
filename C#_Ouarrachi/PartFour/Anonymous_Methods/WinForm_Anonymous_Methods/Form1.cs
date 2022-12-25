namespace WinForm_Anonymous_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn1 = new Button();
            btn1.Text = "Click Here";
            btn1.Size = new Size(124, 47);
            btn1.Location = new Point((ClientSize.Width - btn1.Width) / 2, (ClientSize.Height - btn1.Height) / 2);
            Controls.Add(btn1);

            //btn1.Click += new System.EventHandler(btn1_Click);

            /*
            EventHandler obj = new System.EventHandler(btn1_Click);
            btn1.Click += obj;
            */


            btn1.Click += delegate(object sender, EventArgs e)   // Anonymous Method
            {
                MessageBox.Show("Hello Youssef Good Evening");
            };

        }

        /*
        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Youssef Good Evening");
        }
        */
    }
}