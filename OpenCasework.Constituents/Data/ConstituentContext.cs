using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Models.Constituents;
using OpenCaseWork.Models.Constituents.Domains;

namespace OpenCaseWork.Constituents.Data
{
    public class ConstituentContext : DbContext
    {                
        public DbSet<City> Cities { get; set; }
        public DbSet<Constituent> Constituents { get; set; }
        public DbSet<ConstituentContact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<PostalCodeCity> PostalCodeCities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Suffix> Suffixes { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Township> Townships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.ForSqlServerHasSequence<int>("DBSequence")
                .StartsAt(1000).IncrementsBy(1);
            modelBuilder.Entity<Constituent>()
               .Property(x => x.ConstituentId)
               .HasDefaultValueSql("NEXT VALUE FOR DBSequence");*/
        
            modelBuilder.Entity<PostalCodeCity>()
                .HasKey(c => new { c.CityId, c.PostalCode });
        }

        public ConstituentContext(DbContextOptions<ConstituentContext> options) : base(options)
        {
        }
    }
}
