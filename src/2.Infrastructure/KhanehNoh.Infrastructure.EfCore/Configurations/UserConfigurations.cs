using KhanehNoh.Domain.Core.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Configurations
{
    public class UserConfigurations
    {
        public static void Configuration(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<User>()
                  .HasOne(u => u.Admin)
                  .WithOne(a => a.User)
                  .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                    .HasOne(u => u.Customer)
                    .WithOne(c => c.User)
                    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                  .HasOne(u => u.Expert)
                 .WithOne(e => e.User)
                 .OnDelete(DeleteBehavior.NoAction);



            var passHasher = new PasswordHasher<User>();

            modelBuilder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole<int> { Id = 2, Name = "Expert", NormalizedName = "EXPERT" },
                new IdentityRole<int> { Id = 3, Name = "Customer", NormalizedName = "CUSTOMER" }
            );

            var adminUser = new User
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Rashedi",
                Address = "test1",
                Balance = 250000,
                PictureUrl = "Mahshahr",
                CityId = 1,
                RegisterDate = new DateTime(2025, 2, 2, 0, 0, 0),
                UserName = "admin7878",
                NormalizedUserName = "ADMIN7878",
                Email = "Admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "09036703412",
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),

            };
            adminUser.PasswordHash = passHasher.HashPassword(adminUser, "123456");

            var expertUser = new User
            {
                Id = 2,
                FirstName = "Reza",
                LastName = "Sadeghi",
                Address = "Ahvaz",
                Balance = 20000,
                PictureUrl = "Url1",
                CityId = 1,
                RegisterDate = new DateTime(2025, 2, 16, 0, 0, 0),
                UserName = "reza007",
                NormalizedUserName = "REZA007",
                Email = "Expert@gmail.com",
                NormalizedEmail = "EXPERT@GMAIL.COM",
                PhoneNumber = "09165168696",
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),

            };
            expertUser.PasswordHash = passHasher.HashPassword(expertUser, "123456");

            var customerUser = new User
            {
                Id = 3,
                FirstName = "Arvin",
                LastName = "Rashedi",
                Address = "Tehran",
                Balance = 20000,
                PictureUrl = "Url2",
                CityId = 1,
                RegisterDate = new DateTime(2025, 2, 16, 0, 0, 0),
                UserName = "arvin2013",
                NormalizedUserName = "ARVIN2013",
                Email = "arvin2013@gmail.com",
                NormalizedEmail = "ARVIN2013@GMAIL.COM",
                PhoneNumber = "09926448610",
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            customerUser.PasswordHash = passHasher.HashPassword(customerUser, "123456");

            



            modelBuilder.Entity<User>().HasData(adminUser, expertUser, customerUser);

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> { RoleId = 1, UserId = 1 },
                new IdentityUserRole<int> { RoleId = 2, UserId = 2 },
                new IdentityUserRole<int> { RoleId = 3, UserId = 3 }
                

            );
        }
    }
}





//        public static void SeedUsers(ModelBuilder builder)
//        {
//            var hasher = new PasswordHasher<User>();

//            //SeedUsers
//            var users = new List<User>
//                    {
//                        new User()
//                        {
//                            Id = 1,
//                            FirstName = "Ali",
//                            LastName = "Rashedi",
//                            UserName = "Admin7878",
//                            NormalizedUserName = "ADMIN7878",
//                            Email = "Admin@gmail.com",
//                            NormalizedEmail = "ADMIN@GMAIL.COM",
//                            Balance = 200000,
//                            LockoutEnabled = false,
//                            PhoneNumber = "09036703412",
//                            SecurityStamp = Guid.NewGuid().ToString(),
//                            CityId = 1,
//                            RegisterDate = new DateTime(2025, 2, 16, 21, 0, 0)
//                        }

//                    };

//            foreach (var user in users)
//            {

//                user.PasswordHash = hasher.HashPassword(user, "123456");
//                builder.Entity<User>().HasData(user);
//            }

//            // Seed Roles
//            builder.Entity<IdentityRole<int>>().HasData(
//                new IdentityRole<int>() { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
//                new IdentityRole<int>() { Id = 2, Name = "Expert", NormalizedName = "EXPERT" },
//                new IdentityRole<int>() { Id = 3, Name = "Customer", NormalizedName = "CUSTOMER" }
//            );

//            //Seed Role To Users
//            builder.Entity<IdentityUserRole<int>>().HasData(
//                new IdentityUserRole<int>() { RoleId = 1, UserId = 1 },
//                new IdentityUserRole<int>() { RoleId = 2, UserId = 2 },
//                new IdentityUserRole<int>() { RoleId = 3, UserId = 3 }
//            );
//        }
//    }
//}



