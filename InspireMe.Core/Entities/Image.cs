using InspireMe.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireMe.Core.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime UploadedAt { get; set; }
        // Other image properties

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<ImageTag> ImageTags { get; set; }

        public Image()
        {
            ImageTags = new List<ImageTag>();
        }
    }
}


