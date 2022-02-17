using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace APIOrganisms
{
    class Program
    {
        static async Task  Main(string[] args)
        {
            var http = new HttpClient();
            
            string defontanaAPIurl = "https://test.defontana.com/";
            var response = await http.GetStringAsync(defontanaAPIurl);
            var data = JsonConvert.DeserializeObject(response);
            Console.WriteLine(data);
        
        
        }
    }
}
