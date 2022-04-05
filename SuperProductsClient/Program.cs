using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Linq;

namespace SuperProductsClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get all products from super products api service

            // Step 1: Discover the service location/URI
            string serviceUri = "https://localhost:44301/api/SuperProducts";
            HttpClient httpClient = new HttpClient();
            //string products = httpClient.GetStringAsync(serviceUri).Result;
            List<Item> items =  httpClient.GetFromJsonAsync<List<Item>>(serviceUri).Result;

            foreach (var item in items)
            {
                Console.WriteLine(item.name + "\t" + item.cost);
            }

            Console.WriteLine($"The total cost of all items is {items.Sum(i=>i.cost)}");

        }
    }
}
