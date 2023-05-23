using InspireMe.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireMe.Core.Entities
{
    public class Like
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
