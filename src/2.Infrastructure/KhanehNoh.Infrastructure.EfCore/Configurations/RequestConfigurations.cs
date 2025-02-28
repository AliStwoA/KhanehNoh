using KhanehNoh.Domain.Core;
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

            builder.Property(x => x.Description)
              .HasMaxLength(500);


            builder.HasOne(x => x.Customer)
             .WithMany(x => x.Requests)
             .HasForeignKey(x => x.CustomerId)
             .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
        new Request
        {
            Id = 1,
            Title = "نظافت راه پله",
            Description = "نظافت راه پله 4طبقه ای",
            RegisterDate = new DateTime(2025, 2, 2, 0, 0, 0),
            EndTime = new DateTime(2025, 2, 2, 0, 0, 0),
            IsDeleted = false,
            CityId = 1,
            CustomerId = 1,
            HomeServiceId = 2,
            RequestStatus = OrderStatusEnum.WatingForChoosingExpert

        },
        new Request
        {
            Id = 2,
            Title = "پذیرایی",
            Description = "پذیرایی",
            RegisterDate = new DateTime(2025, 2, 2, 0, 0, 0),
            EndTime = new DateTime(2025, 2, 2, 0, 0, 0),
            IsDeleted = false,
            CityId = 1,
            CustomerId = 1,
            HomeServiceId = 3,
            RequestStatus = OrderStatusEnum.WatingForChoosingExpert

        }
        );



        }
    }
}
