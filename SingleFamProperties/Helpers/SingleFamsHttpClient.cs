using System.Net.Http;

namespace SingleFamProperties.Helpers
{
    /// <summary>
    /// Generic HttpClient for SingleFamProperties Project
    /// </summary>
    /// <remarks>
    /// Not used currently in this project. May use in future.
    /// </remarks>
    public static class SingleFamsHttpClient
    {

        public static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }

}