namespace WinForm_Lambda_Expressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn2 = new Button();
            btn2.Text = "Click Here";
            btn2.Size = new Size(127, 44);
            btn2.Location = new Point((ClientSize.Width - btn2.Width) / 2, (ClientSize.Height - btn2.Height) / 2);
            Controls.Add(btn2);
            btn2.Click += (sender, e) => MessageBox.Show("Hello Youssef Baba");
        }
    }
}