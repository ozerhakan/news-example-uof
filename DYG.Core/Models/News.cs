using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace DYG.Core
{
    public class News : ModelBase
    {
        public ObjectId _id{ get; set; }
        public string Title { get; set; }
        public string Spot { get; set; }
        public string PublishedTime { get; set; }
        public List<string> NewsKeywords { get; set; }
        public MainCategory MainCategory { get; set; }
        public List<SourcesData> SourcesData { get; set; }
        public Story Story { get; set; }
        public Account PublishedAccout { get; set; }
        public Account CreatedAccout { get; set; }
    }
}