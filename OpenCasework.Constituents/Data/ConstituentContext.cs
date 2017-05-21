using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Constituents.Models;
using OpenCaseWork.Constituents.Models.Domains;

namespace OpenCaseWork.Constituents.Data
{
    public class ConstituentContext : DbContext
    {

        //public DbSet<Constituent> Constituents { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Suffix> Suffixes { get; set; }
        public DbSet<City> Cities { get; set; }

        public ConstituentContext(DbContextOptions<ConstituentContext> options) : base(options)
        {
        }
    }
}
