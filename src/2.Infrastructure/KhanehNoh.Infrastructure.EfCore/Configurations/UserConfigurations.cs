using KhanehNoh.Domain.Core.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Mobile).HasMaxLength(11).IsRequired();

            builder.HasMany(x => x.Offers)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Ratings)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);





            builder.HasData(new List<User>()
            {
                new User(){Id = 4, RoleId = 1, Username = "Admin", Email = "Admin@gmail.com", Mobile = "09165168696", CityId = 1, Password= "123456", RegisterAt = DateTime.Now},
                new User(){Id = 5, RoleId = 2, Username = "Expert", Email = "Expert@gmail.com", Mobile = "09037503214", CityId = 1, Password= "123456", RegisterAt = DateTime.Now},
                new User(){Id = 6, RoleId = 3, Username = "Customer", Email = "Customer@gmail.com", Mobile = "0901788665", CityId = 1, Password= "123456", RegisterAt = DateTime.Now},

            });
        }
    }
}
