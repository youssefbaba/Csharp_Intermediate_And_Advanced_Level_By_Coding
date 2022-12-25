namespace When_To_Use_A_Dictionary_Over_List
{
    public class Test
    {
        static void Main(string[] args)
        {
            Country country1 = new Country { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
            Country country2 = new Country { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C" };
            Country country4 = new Country { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };


            /*
            
            Console.WriteLine("------ Program by using list ------ ");
            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);

            string questionYesNo;
            do
            {
                Console.Write("Please enter country code : ");
                string countryCode = Console.ReadLine().ToUpper();
                Country resultCountry = listCountries.Find(country => country.Code == countryCode);
                if (resultCountry == null)
                {
                    Console.WriteLine("Country code not found.");
                }
                else
                {
                    Console.WriteLine($"Name = {listCountries.Find(country => country.Code == countryCode).Name} , Capital = {listCountries.Find(country => country.Code == countryCode).Capital}");
                }
                do
                {
                    Console.Write("Do you want to continue - YES or NO ? : ");
                    questionYesNo = Console.ReadLine().ToUpper();
                } while (!questionYesNo.Equals("YES") && !questionYesNo.Equals("NO"));

            } while (questionYesNo.Equals("YES"));

            */

            Console.WriteLine("------ Program by using dictionary ------ ");
            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code ,country1);
            dictionaryCountries.Add(country2.Code ,country2);
            dictionaryCountries.Add(country3.Code ,country3);
            dictionaryCountries.Add(country4.Code ,country4);
            dictionaryCountries.Add(country5.Code ,country5);
            string userChoice;
            do
            {
                Console.Write("Please enter country code : ");
                string countryCode = Console.ReadLine().ToUpper();
                ;
                if (dictionaryCountries.ContainsKey(countryCode))
                {
                    Console.WriteLine($"Name = {dictionaryCountries[countryCode].Name} , Capital = {dictionaryCountries[countryCode].Capital}");
                }
                else
                {
                    Console.WriteLine("Country code not found.");
                }
                do
                {
                    Console.Write("Do you want to continue - YES or NO ? : ");
                    userChoice = Console.ReadLine().ToUpper();
                } while (!userChoice.Equals("YES") && !userChoice.Equals("NO"));

            } while (userChoice.Equals("YES"));

        }
    }
}