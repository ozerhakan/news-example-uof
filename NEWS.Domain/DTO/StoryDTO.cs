using System.Collections.Generic;

namespace NEWS.Domain.DTO
{
    public class StoryDTO
    {
        public string _id { get; set; }
        public List<ContentDTO> Contents { get; set; }
    }
}