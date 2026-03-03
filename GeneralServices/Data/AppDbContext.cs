using GeneralServices.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GeneralServices.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<GeneralServiceUser> GeneralServiceUsers { get; set; }
    }
}