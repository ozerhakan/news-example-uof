using System;
using System.Collections.Generic;

namespace DYG.Core
{
    public class News : ModelBase
    {
        public string Title { get; set; }
        public string Spot { get; set; }
        public DateTime PublishedTime { get; set; }
        public List<string> NewsKeywords { get; set; }
    }
}