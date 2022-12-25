namespace Amazon
{
    public class Customer
    {
        // Methods
        public void Promote()
        {
            RateCalculator rateCalculator = new RateCalculator();
            int rating = rateCalculator.Calculate(this);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to level 1");
            }
            else
            {
                Console.WriteLine("Promoted to level 2");
            }
        }
        private void DoSomething()
        {
            // Some statements here .....
        }
        protected void TestSomething()
        {
            // Some statements here ....
        }


        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
