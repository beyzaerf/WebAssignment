using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireMe.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        // Other user properties

        public ICollection<Image> Images { get; set; }
        public ICollection<Like> Likes { get; set; }

        public User()
        {
            Images = new List<Image>();
            Likes = new List<Like>();
        }
    }
}