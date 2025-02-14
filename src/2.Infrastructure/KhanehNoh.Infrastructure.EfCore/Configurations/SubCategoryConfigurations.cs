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
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.HomeServices)
                .WithOne(x => x.SubCategory)
                .HasForeignKey(x => x.SubCategoryId);



            builder.HasData(new List<SubCategory>
            {
                new SubCategory{Id = 1, CategoryId = 1, Title = "نظافت و پذیرایی", PictureUrl = ""},
                new SubCategory{Id = 2, CategoryId = 1, Title = "شستشو", PictureUrl=""},
                new SubCategory{Id = 3, CategoryId = 1, Title = "کارواش ودیتیلینگ", PictureUrl=""},

                new SubCategory{Id = 4, CategoryId = 2, Title = "سرمایش و گرمایش", PictureUrl=""},
                new SubCategory{Id = 5, CategoryId = 2, Title = "لوله کشی", PictureUrl=""},
                new SubCategory{Id = 6, CategoryId = 2, Title = "برقکاری", PictureUrl=""},



            });
        }
    }
}
