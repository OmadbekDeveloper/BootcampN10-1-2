using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using N63hometask.Entities;

namespace N63hometask.Data
{
    public class N63HomeTaskDB : DbContext
    {
        public N63HomeTaskDB(DbContextOptions<N63HomeTaskDB> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<StorageFile> StorageFiles { get; set; }



    }
}
