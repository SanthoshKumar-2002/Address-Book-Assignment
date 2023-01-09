using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml.Linq;
using WebApi.Entities.Models;
using WebApi2.Entities.Models;

namespace WebApi2.Entities
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PhoneNumber> phoneNumbers { get; set; }
        public DbSet<Email> emails { get; set; }
        public DbSet<FileModel> Files { get; set; }
        public DbSet<RefSet> refSets { get; set; }
        public DbSet<SetRef> Setrefs { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<metadata> metadatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RefSet>().HasData(
                new RefSet()
                {
                    RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97924"),
                    Name = "PERSONAL",
                    Description = "for the personal"
                },
            new RefSet()
            {
                RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97923"),
                Name = "WORK",
                Description = "for the work"
            },
            new RefSet()
            {
                RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97922"),
                Name = "ALTERNATE",
                Description = "for the alternate"
            },
                new RefSet()
                {
                    RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97914"),
                    Name = "INDIA",
                    Description = "for the country India"
                },
                new RefSet()
                {
                    RefSetId = Guid.Parse("1298FF0D-2062-4594-23D4-08DAC5F97924"),
                    Name = "USA",
                    Description = "for the country USA"
                },
                 new RefSet()
                 {
                     RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97921"),
                     Name = "UK",
                     Description = "for the country UK"
                 },
                  new RefSet()
                  {
                      RefSetId = Guid.Parse("1398FF0D-2062-5594-23D4-08DAC5F97924"),
                      Name = "JAPAN",
                      Description = "for the country Japan"
                  }

                );
            modelBuilder.Entity<User>().HasData(
            new User()
            {
                Id = Guid.Parse("1398FF0D-2062-4594-33D4-08DAC5F97924"),
                UserName = "Kavin",
                Password = "Kavin@123",
                FirstName = "Kavin",
                LastName = "Raja",
                IsActive = true
            });
            modelBuilder.Entity<metadata>().HasData(
            new metadata()
            {
                Id = 1,
                key = "ADDRESS TYPE",
                description = "display the address type",

            },
            new metadata()
            {
                Id = 2,
                key = "PHONE NUMBER TYPE",
                description = "display the phonenumber type",


            },
             new metadata()
             {
                 Id = 3,
                 key = "EMAIL ADDRESS TYPE",
                 description = "display the email type",

             },
              new metadata()
              {
                  Id = 4,
                  key = "Country",
                  description = "display the country of the user"
              },
              new metadata()
              {
                  Id = 5,
                  key = "India",
                  description = "display users from India"

              },
              new metadata()
              {
                  Id = 6,
                  key = "UNITED STATES",
                  description = "display users in united states"
              }

            );

        }
    }
}