using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;


namespace rifki115.Controllers
{
    
    [Route("api/rifki/[controller]")]
    public class HelloController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        { 
            var result = await  GetExternalResponse();
            return new string[] {result,"Hello Rifki"};
         }
    private async Task<string> GetExternalResponse()
    {
        var client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("http://139.59.248.207:5501/api/selly/hello");
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
   //  public static async void DownloadPageAsync()
      //  {
        // ... Target page.
       // string page = "http://139.59.248.207:5501/api/selly/hello";
        // ... Use HttpClient.
     //   using (HttpClient client = new HttpClient())
        //using (HttpResponseMessage response = await client.GetAsync(page))
        //using (HttpContent content = response.Content)
        //{
            // ... Read the string.
          //string result = await content.ReadAsStringAsync();
            // ... Display the result.   
        //}
    //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            Console.WriteLine("");
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
