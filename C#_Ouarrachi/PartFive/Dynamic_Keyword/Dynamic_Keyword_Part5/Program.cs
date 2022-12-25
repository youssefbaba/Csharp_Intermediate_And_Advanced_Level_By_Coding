using IronPython.Hosting;
using Newtonsoft.Json;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace Dynamic_Keyword_Part5
{
    /*
     - dynamic keyword is unsafe and kills the performance of the application.
     - Always use generics over object if you can , Always use object over dynamic .
     */
    public class Program
    {
        static async Task Main(string[] args)
        {
            dynamic calculator = GetCalculator();
            try
            {
                calculator.NonExistingMethod();     // Run-time exception , because double does not contain a definition of NonExistingMethod method
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            var addResult = calculator.Add(10, 20);
            Console.WriteLine($"10 + 20 = {addResult}");
            var mulResult = calculator.Mul(10, 20);
            Console.WriteLine($"10 * 20 = {mulResult}");


            //dynamic example = new dynamic(); // Invalid Object Creation
            dynamic example = new ExpandoObject();
            example.Name = "Marks";
            Console.WriteLine($"The name was = {example.Name}");


            var pythonRuntime = Python.CreateRuntime();
            dynamic pythonFile = pythonRuntime.UseFile("Calculator.py");
            var result = pythonFile.Calculator.add(10, 20);
            Console.WriteLine($"The result was : {result}");


            var httpClient = new HttpClient
            {
                DefaultRequestHeaders =
                {
                    Accept = { new MediaTypeWithQualityHeaderValue("application/vnd.github+json") },
                    UserAgent = {ProductInfoHeaderValue.Parse("request")}
                }
            };
            var responseText = await httpClient.GetStringAsync("https://api.github.com/users/youssefbaba");
            dynamic response = JsonConvert.DeserializeObject(responseText);
            Console.WriteLine($"My Github followers : {response.followers}");
        }

        private static dynamic GetCalculator()
        {
            return new Calculator();
        }
    }
}