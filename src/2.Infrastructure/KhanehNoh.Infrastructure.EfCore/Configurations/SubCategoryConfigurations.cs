using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Configurations
{
    public class SubCategoryConfigurations : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("SubCategories");
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);


            builder.HasOne(x => x.Category)
               .WithMany(x => x.SubCategories)
               .HasForeignKey(x => x.CategoryId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.HomeServices)
                .WithOne(x => x.SubCategory)
                .HasForeignKey(x => x.SubCategoryId)
                .OnDelete(DeleteBehavior.Cascade);



            builder.HasData(new List<SubCategory>
            {
                new SubCategory{Id = 1, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), CategoryId = 1, Title = "نظافت و پذیرایی"},
                new SubCategory{Id = 2, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), CategoryId = 1, Title = "شستشو"},
                new SubCategory{Id = 3, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), CategoryId = 1, Title = "کارواش ودیتیلینگ"},

                new SubCategory{Id = 4, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), CategoryId = 2, Title = "سرمایش و گرمایش"},
                new SubCategory{Id = 5, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), CategoryId = 2, Title = "لوله کشی"},
                new SubCategory{Id = 6, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), CategoryId = 2, Title = "برقکاری"},



            });
        }
    }
}
