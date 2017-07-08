using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Constituents.Models.Search;
using OpenCaseWork.Models.Constituents;
using OpenCaseWork.Models.Constituents.Domains;
using OpenCaseWork.Models.ContactEvents;
using OpenCaseWork.Models.ContactEvents.Domains;

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
        public DbSet<ConstituentSearchRecord> ConstituentSearchRecords { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.HasSequence<int>("ConstituentSequence");
            modelBuilder.Entity<Constituent>()
               .Property(x => x.ConstituentId)
               .HasDefaultValueSql("NEXT VALUE FOR ConstituentSequence");
        
            modelBuilder.Entity<PostalCodeCity>()
                .HasKey(c => new { c.CityId, c.PostalCode });
        }

        public ConstituentContext(DbContextOptions<ConstituentContext> options) : base(options)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}
