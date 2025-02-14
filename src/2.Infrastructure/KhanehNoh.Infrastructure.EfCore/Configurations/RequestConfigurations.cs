using KhanehNoh.Domain.Core.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Configurations
{
    public class RequestConfigurations : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250).IsRequired();
            builder.Property(x => x.ExecutionDate).IsRequired();


            builder.HasMany(x => x.Offers)
                .WithOne(x => x.Request)
                .HasForeignKey(x => x.RequestId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Ratings)
                .WithOne(x => x.Request)
                .HasForeignKey(x => x.RequestId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
