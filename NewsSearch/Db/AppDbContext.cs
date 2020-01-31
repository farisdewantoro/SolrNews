using Microsoft.EntityFrameworkCore;
using NewsSearch.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSearch.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<NewsEntity> News { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsEntity>().HasKey("Id");
            base.OnModelCreating(modelBuilder);
        }

    }
}
