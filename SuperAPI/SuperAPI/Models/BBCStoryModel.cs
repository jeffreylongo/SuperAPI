using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperAPI.Models
{
    public class BBCStoryModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ImgUrl { get; set; }
    }
}