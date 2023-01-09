using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities.Models;
using WebApi2.Entities.Models;

namespace WebApi2Test
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
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
        List<RefSet> list= new List<RefSet>();   

        RefSet ref1 = new RefSet()
        {
            RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97924"),
            Name = "PERSONAL",
            Description = "for the personal"
        };
        RefSet ref2 = new RefSet()
        {
            RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97923"),
            Name = "WORK",
            Description = "for the work"
        };
        RefSet ref3 = new RefSet()
        {
            RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97922"),
            Name = "ALTERNATE",
            Description = "for the alternate"
        };
        RefSet ref4 = new RefSet()
        {
            RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97914"),
            Name = "INDIA",
            Description = "for the country India"
        };
        RefSet ref5 = new RefSet()
        {
            RefSetId = Guid.Parse("1298FF0D-2062-4594-23D4-08DAC5F97924"),
            Name = "USA",
            Description = "for the country USA"
        };
        RefSet ref6 = new RefSet()
        {
            RefSetId = Guid.Parse("1398FF0D-2062-4594-23D4-08DAC5F97921"),
            Name = "UK",
            Description = "for the country UK"
        };
        RefSet ref7 = new RefSet()
        {
            RefSetId = Guid.Parse("1398FF0D-2062-5594-23D4-08DAC5F97924"),
            Name = "JAPAN",
            Description = "for the country Japan"
        };
       
            User user1=new User()
            {
                Id = Guid.Parse("1398FF0D-2062-4594-33D4-08DAC5F97924"),
                UserName = "Kavin",
                Password = "Kavin@123",
                FirstName = "Kavin",
                LastName = "Raja",
                IsActive = true
            };

        metadata meta1 = new metadata()
        {
            Id = 1,
            key = "ADDRESS TYPE",
            description = "display the address type",

        };
        metadata meta2 = new metadata()
        {
            Id = 2,
            key = "PHONE NUMBER TYPE",
            description = "display the phonenumber type",


        };
        metadata meta3 = new metadata()
        {
            Id = 3,
            key = "EMAIL ADDRESS TYPE",
            description = "display the email type",

        };
        metadata meta4 = new metadata()
        {
            Id = 4,
            key = "Country",
            description = "display the country of the user"
        };
             metadata meta5= new metadata()
        {
                  Id = 5,
                  key = "India",
                  description = "display users from India"

              };
        metadata meta6 = new metadata()
        {
            Id = 6,
            key = "UNITED STATES",
            description = "display users in united states"
        };
        }

    }
