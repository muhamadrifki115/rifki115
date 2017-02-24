using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace httpclient
{
    public class httpclienttest
    {
       

        public async Task<string> GetHelloAsync(string folder)
        {
             HttpClient client = new HttpClient();

            string Hello = "";
            client.BaseAddress = new Uri("http://139.59.248.207:5504/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try 
            {
                HttpResponseMessage response = await client.GetAsync(folder);
                if (response.IsSuccessStatusCode)
                {
                    Hello = await response.Content.ReadAsStringAsync();
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Hello;
        }
    }
}