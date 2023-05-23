using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Entity representing the relationship between an image and a tag
namespace InspireMe.Core.Entities
{
    public class ImageTag
    {

        [Key]
        public int ImageId { get; set; }
        public int TagId { get; set; }

        public Image Image { get; set; }
        public Tag Tag { get; set; }
    }
}

