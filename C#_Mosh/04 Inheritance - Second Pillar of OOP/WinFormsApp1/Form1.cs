namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Button button = (Button)sender;        // DownCasting => (Explicit Conversion from object to Button)
            button.Text = "Hiho";
            button.BackColor= Color.Red;
            button.ForeColor = Color.White;
            */

            Button button = sender as Button;
            if (button != null)
            {
                button.Text = "Hiho";
                button.BackColor = Color.Blue;
                button.ForeColor = Color.White;
            }
            MessageBox.Show("Hello World");
        }
    }
}