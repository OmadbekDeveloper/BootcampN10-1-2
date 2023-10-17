using System.ComponentModel.DataAnnotations.Schema;

namespace Photogram.Model
{
    public class Post
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public List<string> ImagePath { get; set; }
    }
}
