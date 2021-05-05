using System;
using System.Collections.Generic;
using System.Runtime;

namespace NEWS.Domain.DTO
{
    public class NewsDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Spot { get; set; }
        public string PublishedTime { get; set; }
        public string CreatedTime { get; set; }
        public List<string> NewsKeywords { get; set; }
        public MainCategoryDTO MainCategory { get; set; }
        public List<SourcesDataDTO> SourcesData { get; set; }
        public AccountDTO PublishedAccount { get; set; }
        public AccountDTO CreatedAccount { get; set; }
        public StoryDTO Story { get; set; }
        public string MainArtUrl { get; set; }
    }
}