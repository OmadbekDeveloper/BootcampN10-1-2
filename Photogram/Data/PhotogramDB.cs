
namespace Photogram.Data
{
    public class PhotogramDB : DbContext
    {
        public PhotogramDB(DbContextOptions<PhotogramDB> options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
