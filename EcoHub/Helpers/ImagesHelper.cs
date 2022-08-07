using System;
using EcoHub.Models;
using Newtonsoft.Json;
using RestSharp;

namespace EcoHub.Helpers
{
    public class ImagesHelper
    {
        public static async Task<Root> CheckImage()
        {
            string apiKey = "acc_ec05c38e83c8294";
            string apiSecret = "d92fe45389ef66d8c9c326cc5f2dcdf8";
            string imageUrl = "https://docs.imagga.com/static/images/docs/sample/japan-605234_1280.jpg";

            string basicAuthValue = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            var client = new RestClient("https://api.imagga.com/v2/tags");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("image_url", imageUrl);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));

            IRestResponse response = client.Execute(request);
            var responseTag = JsonConvert.DeserializeObject<Root>(response.Content);
            return responseTag;
            
        }
    }
}
