using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Form_Using_Queue
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextTokenNumber_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            LabelStatus.Text = $"There are {tokenQueue.Count} customers before you in the queue";

            if (Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }
            int nextTokenNumberToBeIssued = (int)Session["LastTokenNumberIssued"] + 1;
            Session["LastTokenNumberIssued"] = nextTokenNumberToBeIssued;
            tokenQueue.Enqueue(nextTokenNumberToBeIssued);
            AddTokensToListBox(tokenQueue);
        }

        private void AddTokensToListBox(Queue<int> tokenQueue)
        {
            ListTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                ListTokens.Items.Add(token.ToString());
            }
        }

        protected void ListTokens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonCounter1_Click(object sender, EventArgs e)
        {
            ServeNextCustomer(TextCounter1, 1);
        }

        protected void ButtonCounter2_Click(object sender, EventArgs e)
        {
            ServeNextCustomer(TextCounter2, 2);
        }

        protected void ButtonCounter3_Click(object sender, EventArgs e)
        {
            ServeNextCustomer(TextCounter3 , 3);
        }

        private void ServeNextCustomer(TextBox textBox , int counterNumber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue.Count <= 0)
            {
                textBox.Text = "No customers in the queue";
                LabelStatus.Text = "";
            }
            else
            {
                int tokenNumberToBeServed = tokenQueue.Dequeue();
                textBox.Text = tokenNumberToBeServed.ToString();
                TextTokenNumber.Text = $"Token number : {tokenNumberToBeServed} , Please go to Counter {counterNumber}";
                AddTokensToListBox(tokenQueue);
                LabelStatus.Text = $"There are {tokenQueue.Count - 1} customers before you in the queue";
            }
        }

    }
}