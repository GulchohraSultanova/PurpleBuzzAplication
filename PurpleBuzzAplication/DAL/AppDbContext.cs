using Microsoft.EntityFrameworkCore;
using PurpleBuzzAplication.Models;
using System;

namespace PurpleBuzzAplication.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       public DbSet<Services> Services { get; set; }
    }
}
