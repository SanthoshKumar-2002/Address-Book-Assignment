using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApi.Entities.Models;
using WebApi2.Entities;
using WebApi2.Entities.Models;

namespace WebApi2
{
        public static class ApiContext
        {
         public static ApiDbContext inmemory()
        {
            var options = new DbContextOptionsBuilder<ApiDbContext>().UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
            var context=new ApiDbContext(options);
            seeddata(context);
            return context;
        }

        private static void seeddata(ApiDbContext context)
        {
            
                var user=new WebApi.Entities.Models.User();

            user.Id = Guid.Parse(("2CD90236-F155-401D-9A5F-01A782A3B052"));
              user.UserName = "Kavin";
            user.Password = "Kavin@123";
            user.FirstName = "Kavin";
            user.LastName = "Raja";
              user.Email = new List<Email>();
          
                Email email1 = new Email()
                {
                    UserId = Guid.Parse(("2CD90236-F155-401D-9A5F-01A782A3B052")),
                    EmailId = Guid.Parse("2CD90277-F155-401D-9A5F-01A782A3B052"),
                    EmailAddress = "abcd@propel.com",
                    Type = Guid.Parse("2CD90227-F155-401D-9A5F-01A782A3B052"),
                };
            user.Email.Add(email1);
            user.Address = new List<Address>();
            Address address1 = new Address()
            {
                UserId = Guid.Parse(("2CD90236-F155-401D-9A5F-01A782A3B052")),
                AddressId= Guid.Parse(("3CD90236-F155-401D-9A5F-01A782A3B052")),
                Line1 = "182",
                Line2 = "182",
                State = "Tamil Nadu",
                ZipCode = 624617,
                City = "Palani",
                country = Guid.Parse("6CD90227-F155-401D-9A5F-01A782A3B054"),
                Type = Guid.Parse("2CD90227-F155-401D-9A5F-01A782A3B052"),
            };
            user.Address.Add(address1);
            user.phoneNumber = new List<PhoneNumber>();
            PhoneNumber phoneNumber1 = new PhoneNumber()
            {
                UserId = Guid.Parse(("2CD90236-F155-401D-9A5F-01A782A3B052")),
                phoneId = Guid.Parse("2CD90227-F355-401D-9A5F-11A782A3B052"),
                phoneNo = "9003404873",
                Type = Guid.Parse("2CD90227-F155-401D-9A5F-01A782A3B052")
            };
            user.phoneNumber.Add(phoneNumber1);
            user.IsActive = true;
            context.Users.Add(user);
            context.SaveChanges();

            context.metadatas.AddRange(new metadata()
            {
                Id = 1,
                key = "ADDRESS_TYPE",
                description = "return the address type"
            },
            new metadata() { 
                Id = 2,
                key = "EMAIL_TYPE",
                description = "return the email type"
            },
            new metadata()
            {
                Id = 4,
                key = "PHONENUMBER_TYPE",
                description = "return the phoneNumber type"
            });

           context.refSets.AddRange(new WebApi.Entities.Models.RefSet()
            {
                RefSetId = Guid.Parse("2CD90227-F155-401D-9A5F-01A782A3B052"),
                Name = "WORK",
                Description = "for the work",
            },
            new WebApi.Entities.Models.RefSet()
            {
                RefSetId = Guid.Parse("2CD90227-F155-401D-9A5F-01A782A3B053"),
                Name = "PERSONAL",
                Description = "for the personal",
            },
             new WebApi.Entities.Models.RefSet()
             {
                 RefSetId = Guid.Parse("2CD90227-F155-401D-9A5F-01A782A3B054"),
                 Name = "ALTERNATE",
                 Description = "for the alternative",
             },
             new WebApi.Entities.Models.RefSet()
             {
                 RefSetId = Guid.Parse("6CD90227-F155-401D-9A5F-01A782A3B054"),
                 Name = "INDIA",
                 Description = "for the India",
             });
            context.SaveChanges();  


        }
    }
    

}
