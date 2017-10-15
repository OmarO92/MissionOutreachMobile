using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using MissionOutreachMobile.Models;
using Newtonsoft.Json;
namespace MissionOutreachMobile.Data
{
    public class RestService : IRestService
    {
        HttpClient client;
        List<RestCustomers> customers { get; set; }       
        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;

        }


        public async Task<List<RestCustomers>> GetAllCustomersAsync()
        {
            customers = new List<RestCustomers>();
            var uri = new Uri(string.Format(Constants.AllCustomersUrl,string.Empty));
            try {
                var response = await client.GetAsync(uri);
                if(response.IsSuccessStatusCode){
                    var content = await response.Content.ReadAsStringAsync();
                    customers = JsonConvert.DeserializeObject<List<RestCustomers>>(content);
                    Debug.WriteLine(customers.GetType());
                    return customers;
                }
            } catch(Exception ex) {
                Debug.WriteLine($"ERROR GET GetAllCustomersAsync {ex.Message}");
            }
            
            return customers;
        }
    }
}
