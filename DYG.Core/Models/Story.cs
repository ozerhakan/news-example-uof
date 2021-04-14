using System.Collections.Generic;

namespace DYG.Core
{
    public class Content
    {
        public string _t { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
    }
    public class Story
    {
        public string _id { get; set; }
        public List<Content> Contents { get; set; }
    }
}