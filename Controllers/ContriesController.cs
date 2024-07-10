using PMT21RestCountry.Models;
using Newtonsoft.Json;

namespace PMT21RestCountry.Controllers
{
    public class ContriesController
    {
        //GetCountries
        public async static Task<List<Countries>> GetCountries()
        {
            List<Countries> countries = new List<Countries>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = null;
                    response = await client.GetAsync("http://api.countrylayer.com/v2/region/america?access_key=70d24777ce71f44c0d7971ed24c5656f");

                    if (response != null)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var result = response.Content.ReadAsStringAsync().Result;
                            try
                            {
                                var jsonResult = JsonConvert.DeserializeObject<List<Countries>>(result);
                                if(jsonResult != null)
                                {
                                    countries.AddRange(jsonResult);
                                }
                            }
                            catch (JsonException ex)
                            {

                            }
                        }
                    }
                }
                return countries;
            }
            catch (Exception ex)
            {
                return new List<Countries>();
            }
        }
    }
}
