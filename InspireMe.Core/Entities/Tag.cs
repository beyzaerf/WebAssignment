using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireMe.Core.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Other tag properties

        public ICollection<ImageTag> ImageTags { get; set; }

        public Tag()
        {
            ImageTags = new List<ImageTag>();
        }
    }
}
