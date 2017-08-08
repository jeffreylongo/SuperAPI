using Newtonsoft.Json.Linq;
using SuperAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace SuperAPI.Services
{
    public class ApApiServices
    {
        public static IEnumerable<APStoryModel> GetAPNews()
        {
            var url = $"https://newsapi.org/v1/articles?source=associated-press&sortBy=top&apiKey=1031788725c8436e9b0dfd92c9995249";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var rawResponse = String.Empty;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawResponse = reader.ReadToEnd();
            }

            JObject json = JObject.Parse(rawResponse);

            var ApStories = json["articles"]
                .Select(s => new APStoryModel
                {
                    Author = s["author"].ToString(),
                    Title = s["title"].ToString(),
                    Url = s["url"].ToString(),
                    ImgUrl = s["urlToImage"].ToString()
                })
                .GroupBy(g => g.Url).Select(s => s.First());

            return ApStories;
            
        }
    }
}