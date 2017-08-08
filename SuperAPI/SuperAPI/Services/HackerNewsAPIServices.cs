using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SuperAPI.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace SuperAPI.Services
{
    public class HackerNewsAPIServices
    {
        public static IEnumerable<HackerNewsStoryModel> GetHackerNews()
        {
            //connect to API
            var url = $"https://newsapi.org/v1/articles?source=hacker-news&sortBy=top&apiKey=d83621ac9a174c91823a72f6e131fb00";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var rawResponse = String.Empty;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawResponse = reader.ReadToEnd();
            }

            JObject json = JObject.Parse(rawResponse);

            //deserialize json into C# object
            var hackerNewsStories = json["articles"]
                .Select(s => new HackerNewsStoryModel
                {
                    Author = s["author"].ToString(),
                    Title = s["title"].ToString(),
                    Url = s["url"].ToString(),
                    ImgUrl = s["urlToImage"].ToString()
                }).GroupBy(g => g.Url).Select(s => s.First());

            return hackerNewsStories;
        }
    }
}