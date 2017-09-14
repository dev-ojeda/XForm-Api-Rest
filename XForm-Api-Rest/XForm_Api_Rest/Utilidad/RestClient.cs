using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
namespace XForm_Api_Rest.Utilidad
{
    public class RestClient
    {
        public async Task<string> GetAsync(string url)
        {
            string jsonValue = "";
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        jsonValue = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return jsonValue;
        }
    }
}
