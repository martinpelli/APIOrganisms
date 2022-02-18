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
            TreeDataStructure organisms = new TreeDataStructure();

            foreach(var item in data)
            {
                Organism newOrganism = new Organism(item["ID"].ToString(), item["Name"].ToString(), item["Parent"].ToString());
                organisms.AddItemToTree(newOrganism);
            }

            Organism root = new Organism("0", "root", "");
            organisms.PrintTree(root, "", true);





        }
    }
}
