using KnowledgeHubPortal.MVCWebApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeHubPortal.MVCWebApplication.Data
{
    public class ApplicationDbContext : DbContext   //IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Catagory> Catagories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Catagory>().HasData(
                new List<Catagory>
                { new Catagory { CatagoryID = 111, CatagoryName = "Education", Description = "Its good for childerns" },
                  new Catagory { CatagoryID = 222, CatagoryName = "Technology", Description = "All the latest technologies of computer science" },
                    new Catagory { CatagoryID = 333, CatagoryName = "Entertinment", Description = "Better way of passing time" },
                    new Catagory { CatagoryID = 444, CatagoryName = "Social", Description = "Get a social network" } });
        }
    }
}
