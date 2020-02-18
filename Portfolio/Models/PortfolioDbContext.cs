using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace Portfolio.Models
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {
        }

        public DbSet<Home> Homes { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
