namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PartialUser user = new PartialUser();
            user.FirstName = "John";
            user.LastName = "Doe";
            Title.Text = $"Full Name : {user.GetFullName()}";
        }
    }
}