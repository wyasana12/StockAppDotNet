using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = "326994af-582d-4fe0-a772-95b22eae8fd8",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                },
                new IdentityRole
                {
                    Id = "a8277dee-7f4c-43f6-ad90-62942f1dc355",
                    Name = "User",
                    NormalizedName = "USER",
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}