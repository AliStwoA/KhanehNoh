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
    public class OfferConfigurations : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Price)
                .IsRequired();

            builder.Property(s => s.Description)
                .HasMaxLength(500);

            builder.HasOne(s => s.Request)
                .WithMany(s => s.Offers)
                .HasForeignKey(s => s.RequestId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(s => s.Expert)
                .WithMany(s => s.Offers)
                .HasForeignKey(s => s.ExpertId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
            new Offer
            {
                Id = 1,
                Price = 5000,
                DeliveryDate = new DateTime(2025, 2, 16, 0, 0, 0),
                RegisterDate = new DateTime(2025, 2, 16, 0, 0, 0),
                Description = "ارزون",
                OfferStatus = OrderStatusEnum.WatingForChoosingExpert,
                IsDeleted = false,
                RequestId = 1,
                ExpertId = 1,
            },
            new Offer
            {
                Id = 2,
                Price = 6000,
                DeliveryDate = new DateTime(2025, 2, 16, 0, 0, 0),
                RegisterDate = new DateTime(2025, 2, 16, 0, 0, 0),
                Description = "گرون",
                OfferStatus = OrderStatusEnum.WatingForChoosingExpert,
                IsDeleted = false,
                RequestId = 2,
                ExpertId = 1,
            }
            );

        }
    }
}
