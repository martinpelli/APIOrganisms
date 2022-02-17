using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var data = JObject.Parse(response)["data"];
            List<Organism> organisms = new List<Organism>();

            foreach(var item in data)
            {
                Organism newOrganism = new Organism(item["ID"].ToString(), item["Name"].ToString(), item["Parent"].ToString());
                organisms.Add(newOrganism);
                Console.WriteLine(newOrganism.Id);
                Console.WriteLine(newOrganism.Name);
                Console.WriteLine(newOrganism.Parent);

            }





        }
    }
}
